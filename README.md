## Readme Xamarin Prototype
Evaluation Prototype for IMSmobile/app.  
Progress is tracked in [IMSmobile/app/issue/4](https://github.com/IMSmobile/app/issues/4)

## Setup
Install Visual Studio including Xamarin Plugin, Android SDK. ( https://developer.xamarin.com/guides/cross-platform/windows/visual-studio/ )

For macOS install Xamarin Studio (and XCode for Emulation). (https://developer.xamarin.com/guides/cross-platform/xamarin-studio/)

## Inspiration
Guide through Xamarin: https://developer.xamarin.com/guides/ 

Many simple examples for different basicfunctions: https://github.com/xamarin/xamarin-forms-samples

## Playground
No online playground avaible. IDE (Visual Studio or Xamarin Studio) needed.

## Package Catalog
https://www.nuget.org/packages

## Evaluate ecosystem from Xamarin

### Global Player using Xamarin (req 53)
Xamarin is used by Microsoft, Siemens, Pinterest, Slack and over 15'000 other customers (Source: https://www.xamarin.com/customers)
### Challenge documentation: Report on how useful it was when developing prototype app, ist there a upgrade guide, do example work (try three)?
Official Guide/Documentation is excellent (and very enourmous). Sometimes is hard to find the boundary to normal C-Sharp (not everthing is supported by Xamarin). There are good examples from Xamarin.Forms on Github, which explain many basic functions. Github-Examples worked fine.
### Challenge community: How useful where the search results (req 52)?
The xamarin forum activity seems to be okay and official xamarin stuff also answer questions there. Many things could be also found over stackoverflow.com.
### Calculate expected financial cost for project (req 50)
No additional cost for IDE with Xamarin. Team Foundation Server free for max. 5 user. Testcloud (if needed) is 99$ per month!
### Apps can also run in a Browser (req 3)
There is a project in development to use Xamarin with a Browserplugin (https://github.com/xamarin/WebSharp).
### Have been shown to work with CI and CD (req 9, 10)
Build server possible with Jenkins or Teamfoundation Build. Also Testcloud for different devices possible (fee required). More information here: https://developer.xamarin.com/guides/cross-platform/ci/intro_to_ci/

## Additional Requirements

### Https Communication (req 14)
Should be working, but not working in prototype. Alternative HTTP-clients avaible.

### Dynamic Fields (req 21)
Yes, possible to generate.

### Pin Code Protection (req 22)
**No**, but could probably be implemented in native code ([Android Docs](https://developer.android.com/work/device-management-policy.html)).

### Loading Icon (req 23)
Possible to implement, not implemented in prototype.

### Error Handling (req 24)
Error and Exception handling possible.

### Lazy Loading of List (Performance) (req 25)
??

### Async Uploading (App Switch) (req 26)
Should be possilbe, not implemented/tested.

### Network Connection Close (req 27)
Possible.

