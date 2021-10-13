namespace CodeChallenge.Web.Models
{
    using System;

    public class Software
    {
        public string Name { get; set; }
        public string Version { get; set; }

        public bool HigherVersion(string versionToCompare)
        {
            var version1 = new Version(Version);
            var version2 = new Version(versionToCompare);
            var result = version1.CompareTo(version2);
            return result > 0;
        }
    }
}