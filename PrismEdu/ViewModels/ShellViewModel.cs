using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;
using PrismEdu.Models;

namespace PrismEdu.ViewModels
{
    class ShellViewModel
    {
        [Dependency]
        public MessageProvider MessageProvider { get; set; }
    }
}
