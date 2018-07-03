using System;
using Xunit;

namespace XUnitTests
{
    enum ResultEnum
    {
        OverrideResult,
        VirtualResult,
        NewResult,
        NoModifierResult
    }

    public class VirtualOverrideNewAbstractTest
    {

        #region No modifier base class tests
        //[Fact]
        //public void NoModifierOverrideTest()
        //{
        //    NoModifierClass noModifierMember = new NoModifierClass();
        //    Assert.Equal(ResultEnum.NoModifierResult, noModifierMember.Work());

        //    NoModifierOverrideClass overrideMember = new NoModifierOverrideClass();
        //    Assert.NotEqual(ResultEnum.OverrideResult, overrideMember.Work());
        //    Assert.Equal(ResultEnum.NoModifierResult, overrideMember.Work()); // <= no implementation in derrived class, result is from base class
        //}

        [Fact]
        public void NoModifierNewTest()
        {
            NoModifierClass noModifierMember = new NoModifierClass();
            Assert.Equal(ResultEnum.NoModifierResult, noModifierMember.Work());

            NoModifierNewClass newMember = new NoModifierNewClass();
            Assert.Equal(ResultEnum.NewResult, newMember.Work());
        }
        #endregion
        
        #region Abstract base class tests
        [Fact]
        public void AbstractOverrideTest()
        {
            AbstractClass AbstractMember = new AbstractClass();
            Assert.Equal(ResultEnum.AbstractResult, AbstractMember.Work());

            AbstractOverrideClass overrideMember = new AbstractOverrideClass();
            Assert.NotEqual(ResultEnum.OverrideResult, overrideMember.Work());
            Assert.Equal(ResultEnum.AbstractResult, overrideMember.Work());
        }

        [Fact]
        public void AbstractNewTest()
        {
            AbstractClass AbstractMember = new AbstractClass();
            Assert.Equal(ResultEnum.AbstractResult, AbstractMember.Work());

            AbstractNewClass newMember = new AbstractNewClass();
            Assert.Equal(ResultEnum.NewResult, newMember.Work());
        }
#endregion

        [Fact]
        public void VirtualOverrideTest()
        {
            VirtualClass virtualMember = new VirtualClass();
            Assert.Equal(ResultEnum.VirtualResult, virtualMember.Work());

            VirtualOverrideClass overrideMember = new VirtualOverrideClass();
            Assert.Equal(ResultEnum.OverrideResult, overrideMember.Work());
        }
    }

    interface IWorkable
    {
         ResultEnum Work();
    }

    #region No modifier base class
    class NoModifierClass : IWorkable
    {
        public ResultEnum Work()
        {
            return ResultEnum.NoModifierResult;
        }
    }

    //class NoModifierOverrideClass : NoModifierClass, IWorkable
    //{
    //    error. base should be virtual, abstract or override
    //    public override ResultEnum Work()
    //    {
    //        return ResultEnum.OverrideResult;
    //    }
    //}

    class NoModifierNewClass : NoModifierClass, IWorkable
    {
        public new ResultEnum Work()
        {
            return ResultEnum.NewResult;
        }
    }
    #endregion

    #region Abstract base class
    abstract class AbstractClass : IWorkable
    {
        public abstract ResultEnum Work();
    }

    class AbstractOverrideClass : AbstractClass, IWorkable
    {
        public override ResultEnum Work()
        {
            return ResultEnum.OverrideResult;
        }
    }

    //class AbstractNewClass : AbstractClass, IWorkable
    //{
    //    //error. asks for new or override. new will fail as below
    //    //public ResultEnum Work()
    //    //{
    //    //    return ResultEnum.NewResult;
    //    //}

    //    //error. inherited Work() not implemented. not interface related.
    //    //public new ResultEnum Work()
    //    //{
    //    //    return ResultEnum.NewResult;
    //    //}
    //}
    #endregion

    #region Virtual base class
    class VirtualClass : IWorkable
    {
        public virtual ResultEnum Work()
        {
            return ResultEnum.VirtualResult;
        }
    }

    class VirtualOverrideClass : VirtualClass, IWorkable
    {
        public override ResultEnum Work()
        {
            return ResultEnum.OverrideResult;
        }
    }

    class VirtualNewClass : VirtualClass, IWorkable
    {
        public new ResultEnum Work()
        {
            return ResultEnum.NewResult;
        }
    }
    #endregion
}
