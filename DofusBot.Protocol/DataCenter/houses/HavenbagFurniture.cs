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
    public class HavenbagFurniture : IData
    {
        
        public virtual int TypeId
        {
            get
            {
                return mTypeId;
            }
            set
            {
                mTypeId = value;
            }
        }
        
        private int mTypeId;
        
        public virtual int ThemeId
        {
            get
            {
                return mThemeId;
            }
            set
            {
                mThemeId = value;
            }
        }
        
        private int mThemeId;
        
        public virtual int ElementId
        {
            get
            {
                return mElementId;
            }
            set
            {
                mElementId = value;
            }
        }
        
        private int mElementId;
        
        public virtual int Color
        {
            get
            {
                return mColor;
            }
            set
            {
                mColor = value;
            }
        }
        
        private int mColor;
        
        public virtual int SkillId
        {
            get
            {
                return mSkillId;
            }
            set
            {
                mSkillId = value;
            }
        }
        
        private int mSkillId;
        
        public virtual int LayerId
        {
            get
            {
                return mLayerId;
            }
            set
            {
                mLayerId = value;
            }
        }
        
        private int mLayerId;
        
        public virtual bool BlocksMovement
        {
            get
            {
                return mBlocksMovement;
            }
            set
            {
                mBlocksMovement = value;
            }
        }
        
        private bool mBlocksMovement;
        
        public virtual bool IsStackable
        {
            get
            {
                return mIsStackable;
            }
            set
            {
                mIsStackable = value;
            }
        }
        
        private bool mIsStackable;
        
        public virtual uint CellsWidth
        {
            get
            {
                return mCellsWidth;
            }
            set
            {
                mCellsWidth = value;
            }
        }
        
        private uint mCellsWidth;
        
        public virtual uint CellsHeight
        {
            get
            {
                return mCellsHeight;
            }
            set
            {
                mCellsHeight = value;
            }
        }
        
        private uint mCellsHeight;
        
        public virtual uint Order
        {
            get
            {
                return mOrder;
            }
            set
            {
                mOrder = value;
            }
        }
        
        private uint mOrder;
        
        public HavenbagFurniture()
        {
        }
    }
}
