# Ex. 10 WebClient, XmlDocument, Regex, (opt. async/await)

### Task 1: WebClient, XmlDocument
- Download xml file from: https://9gag-rss.com/api/rss/get?code=9GAGComicNoGif&format=1
- Load it to XmlDocument
- Select nodes with tag ```<content>...</content>```
``` xml
<entry>
	<id>https://9gag.com/gag/a1Qw5gw</id>
	<title type="text">Bet ya&#039;ll didn&#039;t know...</title>
	<updated>2019-04-23T18:33:04Z</updated>
	<author>
		<name>9gag-rss.com</name>
		<uri>https://9gag-rss.com</uri>
		<email>noreply@9gag-rss.com</email>
	</author>
	<link href="http://9gag.com/gag/a1Qw5gw"/>
	<content type="html"><a href="http://9gag.com/gag/a1Qw5gw"><img src="https://img-9gag-fun.9cache.com/photo/a1Qw5gw_460s.jpg" /></a>
	</content>
</entry>
```

### Task 2: Create regex expressions:
- ImageUrlPattern - will match whole url of image
- FileNamePattern - will match the file name with extension

### Task 3: Download images
- Download images and save them

### Task 4: Rework solution to async/await
- C# v 7.1 required
- Add this tag to *.csproj 
```<LangVersion>latest</LangVersion>```
- Change Main signature to
``` static async Task Main(string[] args)```
