using System;

namespace Glued
{
    public static class ActionExtensions
    {
        public static Action<T> AsOptional<T>(this Action<T> value)
        {
            return value ?? (_ => { });
        }
    }
}