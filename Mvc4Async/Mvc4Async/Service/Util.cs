using System.Configuration;

namespace Mvc4Async.Service
{
    public static class Util
    {
        public static string getRootUri()
        {
            // For IIS Express, use localhost:7734 
            var uri = "http://localhost:7734/";
            // Get the root URI from Web.config
            uri = Configuration.WidgetServiceURI;
            return uri;
        }

        public static string getServiceUri(string srv)
        {
            return getRootUri() + "api/" + srv;
        }
    }

    public static class Configuration
    {
        private static string _uri = null;

        public static string WidgetServiceURI
        {
            get
            {
                if (!string.IsNullOrEmpty(_uri))
                    return _uri;

                _uri = getKeyVal("WidgetServiceURI");
                if (string.IsNullOrEmpty(_uri))
                    return "http://localhost:7734/";
                else
                    return _uri;
            }
        }
        public static string getKeyVal(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}