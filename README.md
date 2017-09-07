Azure Media Services Flash Player

This sample is WPF and should *just work* on any Windows 10 machine with Visual Studio 2017 15.3.3 and the Desktop development load enabled.

It uses embedded shockwave flash com object to play encrypted video without having to load a web browser and load a remote page just to play the video. Obviously this is desirable because the page load can cause flickering and is slow whereas this is fast and uses the embedded flash player in Internet Explorer thus it gets serviced automatically by Windows Update.

However the video only plays for the first 4 seconds or so. Using Fiddler you can see that it requests multiple chunks and then just fails. 

The sample uses unencrypted video for repro, however passing a token and video with AES etc. in the flashvars has the same result.