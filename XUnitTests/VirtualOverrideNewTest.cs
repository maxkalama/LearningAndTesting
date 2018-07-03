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

    public class VirtualOverrideNewAbstractTests
    {
        class Base
        {
            private readonly int i = 10;
            public virtual int I { get => i; }

            public int j = 20;
        }

        class Derrived: Base
        {
            private readonly int i = 11;
            public override int I { get => i;  }

            public new int j = 21;
        }

        [Fact]
        public void StandaloneTest()
        {
            Base derrivedAsBase = new Derrived();
            Assert.Equal(11, derrivedAsBase.I) ;
            Assert.Equal(20, derrivedAsBase.j); 
        }

        #region Tests using base class members
        #region No modifier base class tests
        //[Fact]
        //public void NoModifierOverrideBaseTest()
        //{
        //    NoModifierClass noModifierMember = new NoModifierClass();
        //    Assert.Equal(ResultEnum.NoModifierResult, noModifierMember.Work());

        //    NoModifierOverrideClass overrideMember = new NoModifierOverrideClass();
        //    Assert.Equal(ResultEnum.OverrideResult, overrideMember.Work()); //no implementation in derrived class, result is from base class
        //}

        [Fact]
        public void NoModifierNewBaseTest()
        {
            NoModifierClass noModifierMember = new NoModifierClass();
            Assert.Equal(ResultEnum.NoModifierResult, noModifierMember.Work());

            NoModifierClass newMember = new NoModifierNewClass();
            Assert.Equal(ResultEnum.NewResult, newMember.Work());
        }
        #endregion

        #region Abstract base class tests
        [Fact]
        public void AbstractOverrideBaseTest()
        {
            //AbstractClass AbstractMember = new AbstractClass(); //can't create abstract class member
            //Assert.Equal(ResultEnum.AbstractResult, AbstractMember.Work());

            AbstractClass overrideMember = new AbstractOverrideClass();
            Assert.Equal(ResultEnum.OverrideResult, overrideMember.Work());
        }

        //[Fact]
        //public void AbstractNewBaseTest()
        //{
        //    AbstractClass AbstractMember = new AbstractClass(); //can't create abstract class member
        //    Assert.Equal(ResultEnum.AbstractResult, AbstractMember.Work());

        //    AbstractClass newMember = new AbstractNewClass(); //AbstractNew class is impossible
        //    Assert.Equal(ResultEnum.NewResult, newMember.Work());
        //}
        #endregion

        #region Virtual base class tests
        [Fact]
        public void VirtualOverrideBaseTest()
        {
            VirtualClass VirtualMember = new VirtualClass();
            Assert.Equal(ResultEnum.VirtualResult, VirtualMember.Work());

            VirtualClass overrideMember = new VirtualOverrideClass();
            Assert.Equal(ResultEnum.OverrideResult, overrideMember.Work());
        }

        [Fact]
        public void VirtualNewBaseTest()
        {
            VirtualClass VirtualMember = new VirtualClass();
            Assert.Equal(ResultEnum.VirtualResult, VirtualMember.Work());

            VirtualClass newMember = new VirtualNewClass();
            Assert.Equal(ResultEnum.NewResult, newMember.Work());
        }
        #endregion 
        #endregion

        #region Tests using derrived class members
        #region No modifier base class tests
        //[Fact]
        //public void NoModifierOverrideDerrivedTest()
        //{
        //    NoModifierClass noModifierMember = new NoModifierClass();
        //    Assert.Equal(ResultEnum.NoModifierResult, noModifierMember.Work());

        //    NoModifierOverrideClass overrideMember = new NoModifierOverrideClass();
        //    Assert.NotEqual(ResultEnum.OverrideResult, overrideMember.Work());
        //    Assert.Equal(ResultEnum.NoModifierResult, overrideMember.Work()); //no implementation in derrived class, result is from base class
        //}

        [Fact]
        public void NoModifierNewDerrivedTest()
        {
            NoModifierClass noModifierMember = new NoModifierClass();
            Assert.Equal(ResultEnum.NoModifierResult, noModifierMember.Work());

            NoModifierNewClass newMember = new NoModifierNewClass();
            Assert.Equal(ResultEnum.NewResult, newMember.Work());
        }
        #endregion

        #region Abstract base class tests
        [Fact]
        public void AbstractOverrideDerrivedTest()
        {
            //AbstractClass AbstractMember = new AbstractClass(); //can't create abstract class member
            //Assert.Equal(ResultEnum.AbstractResult, AbstractMember.Work());

            AbstractOverrideClass overrideMember = new AbstractOverrideClass();
            Assert.Equal(ResultEnum.OverrideResult, overrideMember.Work());
        }

        //[Fact]
        //public void AbstractNewDerrivedTest()
        //{
        //    AbstractClass AbstractMember = new AbstractClass(); //can't create abstract class member
        //    Assert.Equal(ResultEnum.AbstractResult, AbstractMember.Work());

        //    AbstractNewClass newMember = new AbstractNewClass(); //AbstractNew class is impossible
        //    Assert.Equal(ResultEnum.NewResult, newMember.Work());
        //}
        #endregion

        #region Virtual base class tests
        [Fact]
        public void VirtualOverrideDerrivedTest()
        {
            VirtualClass VirtualMember = new VirtualClass();
            Assert.Equal(ResultEnum.VirtualResult, VirtualMember.Work());

            VirtualOverrideClass overrideMember = new VirtualOverrideClass();
            Assert.Equal(ResultEnum.OverrideResult, overrideMember.Work());
        }

        [Fact]
        public void VirtualNewDerrivedTest()
        {
            VirtualClass VirtualMember = new VirtualClass();
            Assert.Equal(ResultEnum.VirtualResult, VirtualMember.Work());

            VirtualNewClass newMember = new VirtualNewClass();
            Assert.Equal(ResultEnum.NewResult, newMember.Work());
        }
        #endregion 
        #endregion

        #region Tests using interface class members
        #region No modifier base class tests
        //[Fact]
        //public void NoModifierOverrideInterfaceTest()
        //{
        //    IWorkable noModifierMember = new NoModifierClass();
        //    Assert.Equal(ResultEnum.NoModifierResult, noModifierMember.Work());

        //    IWorkable overrideMember = new NoModifierOverrideClass();
        //    Assert.NotEqual(ResultEnum.OverrideResult, overrideMember.Work());
        //    Assert.Equal(ResultEnum.NoModifierResult, overrideMember.Work()); //no implementation in derrived class, result is from base class
        //}

        [Fact]
        public void NoModifierNewInterfaceTest()
        {
            IWorkable noModifierMember = new NoModifierClass();
            Assert.Equal(ResultEnum.NoModifierResult, noModifierMember.Work());

            IWorkable newMember = new NoModifierNewClass();
            Assert.Equal(ResultEnum.NewResult, newMember.Work());
        }
        #endregion

        #region Abstract base class tests
        [Fact]
        public void AbstractOverrideInterfaceTest()
        {
            //IWorkable AbstractMember = new AbstractClass(); //can't create abstract class member
            //Assert.Equal(ResultEnum.AbstractResult, AbstractMember.Work());

            IWorkable overrideMember = new AbstractOverrideClass();
            Assert.Equal(ResultEnum.OverrideResult, overrideMember.Work());
        }

        //[Fact]
        //public void AbstractNewInterfaceTest()
        //{
        //    AbstractClass AbstractMember = new AbstractClass(); //can't create abstract class member
        //    Assert.Equal(ResultEnum.AbstractResult, AbstractMember.Work());

        //    AbstractNewClass newMember = new AbstractNewClass(); //AbstractNew class is impossible
        //    Assert.Equal(ResultEnum.NewResult, newMember.Work());
        //}
        #endregion

        #region Virtual base class tests
        [Fact]
        public void VirtualOverrideInterfaceTest()
        {
            IWorkable VirtualMember = new VirtualClass();
            Assert.Equal(ResultEnum.VirtualResult, VirtualMember.Work());

            IWorkable overrideMember = new VirtualOverrideClass();
            Assert.Equal(ResultEnum.OverrideResult, overrideMember.Work());
        }

        [Fact]
        public void VirtualNewInterfaceTest()
        {
            IWorkable VirtualMember = new VirtualClass();
            Assert.Equal(ResultEnum.VirtualResult, VirtualMember.Work());

            IWorkable newMember = new VirtualNewClass();
            Assert.Equal(ResultEnum.NewResult, newMember.Work());
        }
        #endregion 
        #endregion
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
    //    //error. inherited Work() not implemented. not interface related.
    //    //public new ResultEnum Work()
    //    //{
    //    //    return ResultEnum.NewResult;
    //    //}
    //
    //    //error. asks for new or override. new will fail as above. override is another class.
    //    //public ResultEnum Work()
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
