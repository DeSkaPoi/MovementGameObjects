﻿using MovementGameObjects.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementGameObjects.Abstractions
{
    public abstract class Move
    {
        protected readonly IMovable _movable;
        public Move(IMovable movable) => _movable = movable;

        public abstract void Execute();
    }
}
