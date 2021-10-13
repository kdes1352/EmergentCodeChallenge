namespace CodeChallenge.Web.Models
{
    using System;

    public class Software
    {
        public string Name { get; set; }
        public string Version { get; set; }

        public bool HigherVersion(string versionToCompare)
        {
            // returns true if version 1 (the version from the list) is higher than version 2 (the number input by the user). 
            var listVersion = new Version(Version);
            var inputVersion = new Version(versionToCompare);
            var result = listVersion.CompareTo(inputVersion);
            return result > 0;
        }
    }
}