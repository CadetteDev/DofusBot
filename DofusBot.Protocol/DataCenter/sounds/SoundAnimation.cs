//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.DataCenter
{
    using System.Collections.Generic;
    using DofusBot.Protocol;
    using System;
    
    
    [Serializable()]
    public class SoundAnimation : IData
    {
        
        public virtual uint Id
        {
            get
            {
                return mId;
            }
            set
            {
                mId = value;
            }
        }
        
        private uint mId;
        
        public virtual string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        
        private string mName;
        
        public virtual string Label
        {
            get
            {
                return mLabel;
            }
            set
            {
                mLabel = value;
            }
        }
        
        private string mLabel;
        
        public virtual string Filename
        {
            get
            {
                return mFilename;
            }
            set
            {
                mFilename = value;
            }
        }
        
        private string mFilename;
        
        public virtual int Volume
        {
            get
            {
                return mVolume;
            }
            set
            {
                mVolume = value;
            }
        }
        
        private int mVolume;
        
        public virtual int Rolloff
        {
            get
            {
                return mRolloff;
            }
            set
            {
                mRolloff = value;
            }
        }
        
        private int mRolloff;
        
        public virtual int AutomationDuration
        {
            get
            {
                return mAutomationDuration;
            }
            set
            {
                mAutomationDuration = value;
            }
        }
        
        private int mAutomationDuration;
        
        public virtual int AutomationVolume
        {
            get
            {
                return mAutomationVolume;
            }
            set
            {
                mAutomationVolume = value;
            }
        }
        
        private int mAutomationVolume;
        
        public virtual int AutomationFadeIn
        {
            get
            {
                return mAutomationFadeIn;
            }
            set
            {
                mAutomationFadeIn = value;
            }
        }
        
        private int mAutomationFadeIn;
        
        public virtual int AutomationFadeOut
        {
            get
            {
                return mAutomationFadeOut;
            }
            set
            {
                mAutomationFadeOut = value;
            }
        }
        
        private int mAutomationFadeOut;
        
        public virtual bool NoCutSilence
        {
            get
            {
                return mNoCutSilence;
            }
            set
            {
                mNoCutSilence = value;
            }
        }
        
        private bool mNoCutSilence;
        
        public virtual uint StartFrame
        {
            get
            {
                return mStartFrame;
            }
            set
            {
                mStartFrame = value;
            }
        }
        
        private uint mStartFrame;
        
        public SoundAnimation()
        {
        }
    }
}
