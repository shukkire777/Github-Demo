using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGithub.Model
{
    public interface IMyModel
    {
        public string GetValue();
        public void SetValue(string anyValue);
    }

    public class MyModel : IMyModel
    {
        private string Name { get; set; }

        public string GetValue()
        {
            return Name;
        }

        public void SetValue(string anyValue)
        {
            Name=anyValue;
        }
    }
}
