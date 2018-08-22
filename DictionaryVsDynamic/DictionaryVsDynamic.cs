using System;
using System.Collections.Generic;

namespace DictionaryVsDynamic
{

    //Theirs library code

    public class LibraryMethodParameters
    {
        public string CardToken { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
    }

    public class LibraryResult
    {
        public byte ResultCode { get; set; }
    }

    public class TheirsStrtipeLibrary
    {
        public LibraryResult StripeLibraryMethod(LibraryMethodParameters request)
        {
            return new LibraryResult() { ResultCode = 0 };
        }
    }

    //Our Service Code (we have refference to LibraryMethodParameters)

    public abstract class OurCustomRequestProperties
    {
        public Dictionary<string, object> CustomProperties { get; set; } // <= Dictionary option
        public dynamic DynamicCustomProperties { get; set; } // <= dynamic option
    }

    public class OurStripeRequestProperties: OurCustomRequestProperties
    {
        public decimal Amount { get; set; }
    }

    public class OurServiceLayerClass
    {
        public dynamic HitTheRequest(OurStripeRequestProperties request)
        {
            var theirsLibraryInstance = new TheirsStrtipeLibrary();
            var libraryRequest = new LibraryMethodParameters();
            libraryRequest.Amount = request.Amount;
            libraryRequest.CurrencyCode = (string)request.CustomProperties["CurrencyCode"]; // <= we need to use string property name and use casting of type
            libraryRequest.CardToken = request.DynamicCustomProperties.CardToken; // <= no casting, property name close to string name
            var result = theirsLibraryInstance.StripeLibraryMethod(libraryRequest);

            return result;
        }
    }

    //Calling project code (no access to the LibraryMethodParameters)

    public class OurCallingClass
    {
        public void OurCallingMethod()
        {
            var request = new OurStripeRequestProperties();
            request.Amount = 99;
            request.CustomProperties = new Dictionary<string, object>() { { "CurrencyCode", "usd" } }; //using dictionary 
            request.DynamicCustomProperties = new { CardToken = "token" }; //using dynamic

            var ourService = new OurServiceLayerClass();
            var result = ourService.HitTheRequest(request);
        }
    }
}
