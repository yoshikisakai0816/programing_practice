using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class Iterator1
    {
        public IEnumerable<string> GetStrings()
        {
            yield return "sakai";
            yield return "ninngenn";
            yield return "tennsinnhan";
        }

        public IEnumerator<string> GetStrings2()
        {
            yield return "rika";
            yield return "fsaka";
            yield return "ijfksaniika";
        }
    }
}
