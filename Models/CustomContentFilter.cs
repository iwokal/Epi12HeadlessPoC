//using EPiServer.ContentApi.Core.Serialization;
//using EPiServer.ContentApi.Core.Serialization.Models;
//using EPiServer.Core;
//using EPiServer.SpecializedProperties;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using EPiServer.ContentApi.Core.Serialization.Internal;
//using EPiServer.ServiceLocation;

//namespace epi12.Models
//{
//    [ServiceConfiguration(typeof(IContentFilter), Lifecycle = ServiceInstanceScope.Singleton)]
//    internal class CustomContentFilter : ContentFilter<IContent>
//    {
//        public override void Filter(IContent content, ConverterContext converterContext)
//        {
//            //content.Property.Remove("PageImage");
//            //content.Property.Remove("MainContentArea");
//        }
//    }
//}