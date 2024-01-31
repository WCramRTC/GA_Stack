﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Stack
{
    internal class MyStack<T>
    {
        protected class StackNode<T>
        {
            T data;
            StackNode<T> _next;

            public StackNode(T data, StackNode<T> next)
            {
                this.data = data;
                _next = next;
            } // StackNode

        } // class


    } // class

} // namespace
