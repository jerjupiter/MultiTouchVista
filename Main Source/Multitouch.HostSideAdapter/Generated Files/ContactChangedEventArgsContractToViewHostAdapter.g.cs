//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Multitouch.Contracts.HostSideAdapters
{
    
    public class ContactChangedEventArgsContractToViewHostAdapter : Multitouch.Contracts.ContactChangedEventArgs
    {
        private Multitouch.Contracts.Contracts.IContactChangedEventArgsContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        static ContactChangedEventArgsContractToViewHostAdapter()
        {
        }
        public ContactChangedEventArgsContractToViewHostAdapter(Multitouch.Contracts.Contracts.IContactChangedEventArgsContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
        }
        public override Multitouch.Contracts.IContact Contact
        {
            get
            {
                return Multitouch.Contracts.HostSideAdapters.IContactHostAdapter.ContractToViewAdapter(_contract.Contact);
            }
        }
        internal Multitouch.Contracts.Contracts.IContactChangedEventArgsContract GetSourceContract()
        {
            return _contract;
        }
    }
}

