//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Management;
//using System.Text;
//using System.Threading.Tasks;

//namespace studyBuddy.programComponents.loginNeeds
//{
//    abstract class DeviceIdentifier
//    {
//        private static string identifier = "";
//        //if you want to identify device suggestions:
//        //MAC + CPUID + HDDserial
//        //using 2/3 rule in case of parts replacement.
//        //CPUID is the most stable / unchangeable. Possible issues with old systems
//        //----------------------------------
//        //the retrieving of CPU info is the most time-consuming request.
//        //----------------------------------
//        //we will not use it 2/3 rule
//        //CPUID will be used in our case
//        //http://www.codescratcher.com/windows-forms/get-computer-hardware-information-using-c/
//        public static string GetIdentifier()
//        {
//            if (identifier.Length > 0)
//                return identifier;
//            //identifier not used
//            var mc = new ManagementClass("win32_processor");
//            ManagementObjectCollection moc = mc.GetInstances();
//            identifier = "";
//            foreach (var mo in moc)
//            {
//                identifier = mo.Properties["processorID"].Value.ToString();
//                break;
//            }
//            return identifier;
//        }
//    }
//}
