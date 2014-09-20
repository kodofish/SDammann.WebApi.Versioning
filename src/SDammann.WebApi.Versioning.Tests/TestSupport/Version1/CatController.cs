﻿namespace SDammann.WebApi.Versioning.Tests.TestSupport.Version1 {
    using System.Web.Http;

    internal class CatController : ApiController {
        
    }

    namespace Version {
        internal class CatControllerInVersionNamespace : ApiController
        {

        }
    }

    internal class CatCtrl : CatController {
        
    }

    internal class Controller : ApiController {
        
    }


    namespace Version2_5 {
        internal class VersionTwoDotFiveController : ApiController {
            
        }
    }
}

internal class ControllerWithNoNamespace {
    
}

namespace SDammann.WebApi.Versioning.Tests.TestSupport {
    internal class ControllerWithNoVersionNamespace {
        
    }

}