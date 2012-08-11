using System.Collections.Generic;

namespace DevTests.CSharp.Recursion
{
    public class Folder
    {
        public string Name { get; set; }
        public List<Folder> Children { get; set; }
        
        public override string ToString()
        {
            return null;
        }        
    }
}