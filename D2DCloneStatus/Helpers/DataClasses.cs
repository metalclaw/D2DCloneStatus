using System;

namespace D2DCloneStatus
{
    public static class Helpers
    {
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }
    }

    public class Response
    {
        public int progress { get; set; }
        public int region { get; set; }
        public int ladder { get; set; }
        public int hc { get; set; }
        public int timestamped { get; set; }
        public int reporter_id { get; set; }

        public ResponseForOLV convertForOLV()
        {
            ResponseForOLV response = new ResponseForOLV();

            response.region = ((RegionMapping)region).ToString();
            response.progress = (progress).ToString() + "/6";
            response.ladder = ((LadderMapping)ladder).ToString();
            response.hc = ((HCMapping)hc).ToString();
            response.lastReport = Form1.parseTimestamp(timestamped);

            return response;
        }
    }

    public class ResponseForOLV
    {
        public string region { get; set; }
        public string progress { get; set; }
        public string ladder { get; set; }
        public string hc { get; set; }
        public string lastReport { get; set; }
    }
}