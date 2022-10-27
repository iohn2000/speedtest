namespace SpeedTest.Data;
public class SpeedTestResult
{
    public SpeedTestResult(string environmentName = "MeshedPotatoe")
    {
        this.EnvironmentDescription = environmentName;
    }
	public string EnvironmentDescription { get; set; }
	/// <summary>date when test is run</summary>
	public DateTime RunDate { get; set; }
	/// <summary>download speed in bytes per second; divide by 125000 to get MegaBits/Sec </summary>
	public int Download { get; set; }
	/// <summary>download speed in bytes per second</summary>
	public int Upload { get; set; }
	/// <summary>in mlliseconds rounded to no decimal places</summary>
	public int PingLatency { get; set; }
}