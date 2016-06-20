﻿#region [R# naming]
// ReSharper disable ArrangeTypeModifiers
// ReSharper disable UnusedMember.Local
// ReSharper disable FieldCanBeMadeReadOnly.Local
// ReSharper disable ArrangeTypeMemberModifiers
// ReSharper disable InconsistentNaming
#endregion
using NUnit.Framework;
using Slant.Expectations;

namespace NSpectator.Specs.Running
{
    public class Describe_Levels_Inheritance : When_running_specs
    {
        class Parent_context : Spec { }

        class Child_context : Parent_context
        {
            void it_is()
            {
                "is".Expected().ToBe("is");
            }
        }

        [SetUp]
        public void Setup()
        {
            Run(new[] { typeof(Parent_context), typeof(Child_context) });
        }

        [Test]
        public void Parent_class_is_level_1()
        {
            TheContext("parent context").Level.Expected().ToBe(1);
        }

        [Test]
        public void Child_class_is_level_2()
        {
            TheContext("child context").Level.Expected().ToBe(2);
        }
    }
}