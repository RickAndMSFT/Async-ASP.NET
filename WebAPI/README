<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="en-us" http-equiv="Content-Language" />
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>MVC4Async Setup</title>
<style type="text/css">
 p.MsoNormal
	{margin-top:0in;
	margin-right:0in;
	margin-bottom:10.0pt;
	margin-left:0in;
	line-height:115%;
	font-size:11.0pt;
	font-family:"Calibri","sans-serif";
	}
.auto-style2 {
	background-color: #E8D28A;
}
</style>
</head>

<body>

<ol>
	<li>Start the Web API server application (WebAPIpgw). The project is set to 
	use IIS Express with port 7734 (http://localhost:7734/). You can run the 
	WebAPIpgw on local host or on a remote server. Test that the service is working with either IIS Express or localhost.
	When you click on a link in IE, you should see a message like <br />
	<span class="auto-style2">Do you want to&nbsp; open or save <strong>gizmos</strong> 
	(282) bytes from localhost? </span> <br />In FF/Chrome You'll see the data and know the service is working. <ul>
		<li>Verify WebAPIpgw is working correctly with the following URLs 
		(depending if you are using IIS Express or localhost). The default is 
		IIS Express with port 7734.</li>
		<li><a href="http://localhost:7734/api/gizmos">
		http://localhost:7734/api/gizmos</a></li>
		<li><a href="http://localhost:7734/api/products">
		http://localhost:7734/api/products</a></li>
		<li><a href="http://localhost:7734/api/widgets">
		http://localhost:7734/api/widgets</a></li>
        <li><a href="http://localhost/WebAPIpgw/api/gizmos">http://localhost/WebAPIpgw/api/gizmos</a></li>
        <li><a href="http://localhost/WebAPIpgw/api/products">http://localhost/WebAPIpgw/api/products</a></li>
	</ul>
	</li>
	<li>Follow this step only if you wish to host the WebAPIpgw service on a 
	different computer than you run theMVC4Async application. If you change the&nbsp; 
	hosting server of the WebAPIpgw service, record&nbsp; the server for the MVC4Async 
	application. For example if the WebAPIpgw service is hosted on a computer named 
	<strong>kaVS430</strong>, the root URI 
	would be http://kaVS430/WebAPIpgw/ and you would store that value in the 
	MVC4Async application Web.config file as <br />
&nbsp;
	<p class="MsoNormal" style="margin-bottom: 0in; margin-bottom: .0001pt; line-height: normal; mso-layout-grid-align: none; text-autospace: none">
	<span style="font-size: 9.5pt; font-family: Consolas; color: blue; background: white; mso-highlight: white">
	&lt;</span><span style="font-size: 9.5pt; font-family: Consolas; color: #A31515; background: white; mso-highlight: white">appSettings</span><span style="font-size: 9.5pt; font-family: Consolas; color: blue; background: white; mso-highlight: white">&gt;</span><span style="font-size: 9.5pt; font-family: Consolas; color: black; background: white; mso-highlight: white"><o:p></o:p></span></p>
	<p class="MsoNormal" style="margin-bottom: 0in; margin-bottom: .0001pt; line-height: normal; mso-layout-grid-align: none; text-autospace: none">
	<span style="font-size: 9.5pt; font-family: Consolas; color: blue; background: white; mso-highlight: white">
	<span style="mso-spacerun: yes">&nbsp;&nbsp;&nbsp; </span>&lt;</span><span style="font-size: 9.5pt; font-family: Consolas; color: #A31515; background: white; mso-highlight: white">add</span><span style="font-size: 9.5pt; font-family: Consolas; color: blue; background: white; mso-highlight: white">
	</span>
	<span style="font-size: 9.5pt; font-family: Consolas; color: red; background: white; mso-highlight: white">
	key</span><span style="font-size: 9.5pt; font-family: Consolas; color: blue; background: white; mso-highlight: white">=</span><span style="font-size: 9.5pt; font-family: Consolas; color: black; background: white; mso-highlight: white">"</span><span style="font-size: 9.5pt; font-family: Consolas; color: blue; background: white; mso-highlight: white">WidgetServiceURI</span><span style="font-size: 9.5pt; font-family: Consolas; color: black; background: white; mso-highlight: white">"</span><span style="font-size: 9.5pt; font-family: Consolas; color: blue; background: white; mso-highlight: white">
	</span>
	<span style="font-size: 9.5pt; font-family: Consolas; color: red; background: white; mso-highlight: white">
	value</span><span style="font-size: 9.5pt; font-family: Consolas; color: blue; background: white; mso-highlight: white">=</span><span style="font-size: 9.5pt; font-family: Consolas; color: black; background: white; mso-highlight: white">"</span><span style="font-size: 9.5pt; font-family: Consolas; color: blue; background: white; mso-highlight: white">http://kaVS430/WebAPIpgw/</span><span style="font-size: 9.5pt; font-family: Consolas; color: black; background: white; mso-highlight: white">"</span><span style="font-size: 9.5pt; font-family: Consolas; color: blue; background: white; mso-highlight: white"> 
	/&gt;</span><span style="font-size: 9.5pt; font-family: Consolas; color: black; background: white; mso-highlight: white"><o:p></o:p></span></p>
	<p class="MsoNormal">
	<span style="font-size: 9.5pt; line-height: 115%; font-family: Consolas; color: blue; background: white; mso-highlight: white">
	<span style="mso-spacerun: yes">&nbsp;&nbsp;&nbsp; </span>&lt;!--</span><span style="font-size: 9.5pt; line-height: 115%; font-family: Consolas; color: green; background: white; mso-highlight: white"><span style="mso-spacerun: yes">&nbsp;&nbsp;
	</span></span>
	<span style="font-size: 9.5pt; line-height: 115%; font-family: Consolas; color: green">
	items removed </span>
	<span style="font-size: 9.5pt; line-height: 115%; font-family: Wingdings; mso-ascii-font-family: Consolas; mso-hansi-font-family: Consolas; mso-bidi-font-family: Consolas; color: green; mso-char-type: symbol; mso-symbol-font-family: Wingdings">
	<span style="mso-char-type: symbol; mso-symbol-font-family: Wingdings">à</span></span><span style="font-size: 9.5pt; line-height: 115%; font-family: Consolas; color: green"><br />
	</span>
	<span style="font-size: 9.5pt; line-height: 115%; font-family: Consolas; color: blue; background: white; mso-highlight: white">
	&lt;/</span><span style="font-size: 9.5pt; line-height: 115%; font-family: Consolas; color: #A31515; background: white; mso-highlight: white">appSettings</span><span style="font-size: 9.5pt; line-height: 115%; font-family: Consolas; color: blue; background: white; mso-highlight: white">&gt;</span><o:p></o:p></p>
	</li>
	<li>Run the MVC4Async application.</li>
	<li>To control the simulated latency, change the delay in the GetDelay 
	method in the&nbsp; WebAPIpgw\Utility\Util.cs file.</li>
</ol>

</body>

</html>
