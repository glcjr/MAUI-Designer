﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDesigner.LayoutDesigners
{
    public interface ILayoutDesigner
    {
        public void OnDrop(View view, Point location);
    }
}
