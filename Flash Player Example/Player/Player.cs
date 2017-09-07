using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace CADLearning.Windows.Player
{
    public partial class Player: UserControl, IDisposable
    {
        public Player()
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            if (disposing && flash != null && !flash.IsDisposed)
            {
                flash.Dispose();
                flash = null;
            }

            base.Dispose(disposing);
        }


        public void PlayVideo(string videoUrl)
        {
            flash.FlashVars = $"playerId=no_player_component_399&controlBarMode=none&playButtonOverlay=false&bufferingOverlay=false&AdaptiveStreamingPlugin_retryLive=true&autoPlay=true&preload=undefined&loop=undefined&muted=undefined&sendRawDataToJS=false&src={WebUtility.UrlEncode(videoUrl)}&AdaptiveStreamingPlugin_minimumBufferTimeInSeconds=4&AdaptiveStreamingPlugin_maximumBufferTimeInSeconds=30&AdaptiveStreamingPlugin_livePlaybackOffsetInSecond=8&AdaptiveStreamingPlugin_enableOSMFLogging=true&AdaptiveStreamingPlugin_minimalLogLevel=0&";

            flash.Movie = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "StrobeMediaPlayback.2.0.swf");

            flash.Play();
        }
    }
}
