﻿using System;
using True.KenticoMapper.Core.Attributes;

namespace True.KenticoMapper.TreeNode.Attributes
{
    public interface ISyncInComplex : INamed
    {
        Type Type { get; }
    }
}