using System;



namespace Kohde.Assessment
    
{
    public class Dog : IDisposable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Food { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public string GetDetails()
        {
            return "Name: " + Name + ", Age: " + Age;
        }
    }
}