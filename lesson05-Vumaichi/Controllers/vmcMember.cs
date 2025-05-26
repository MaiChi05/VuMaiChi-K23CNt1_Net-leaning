namespace lesson05_Vumaichi.Controllers
{
    internal class VmcMember
    {
        internal string VmcUserName;

        public VmcMember()
        {
        }

        public string VmcMemberId { get; internal set; }
        public string VmcFullName { get; internal set; }
        public string VmcPassword { get; internal set; }
        public string VmcEmail { get; internal set; }
    }
}