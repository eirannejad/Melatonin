using System.Windows.Forms;

namespace Melatonin {
    class Program {
        static void Main(string[] args) {
            // put machine to sleep
            // source: https://stackoverflow.com/a/2080083
            Application.SetSuspendState(PowerState.Suspend, true, true);
        }
    }
}
