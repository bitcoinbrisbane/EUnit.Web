using System;
namespace EUnitWebApp.Models
{
    public class ContractParams
    {
        public String Abi { get; set; }
        
        //[Regex]
        public String Bytes { get; set; }
        
        public ContractParams()
        {
        }
    }
}
