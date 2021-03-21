using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Adapter
{
    public class SkinToPeelAdapter : IPeelable
    {
        private ISkinnable Skinnable;

        public SkinToPeelAdapter(ISkinnable skinnable)
        {
            Skinnable = skinnable;
        }

        public void Peel()
        {
            Skinnable.Skin();
        }
    }
}
