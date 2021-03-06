﻿#region [R# naming]

// ReSharper disable ArrangeTypeModifiers
// ReSharper disable UnusedMember.Local
// ReSharper disable FieldCanBeMadeReadOnly.Local
// ReSharper disable ArrangeTypeMemberModifiers
// ReSharper disable InconsistentNaming

#endregion

using NSpectator;
using Slant.Expectations;

namespace SampleSpecs.Demo
{
    class SomeSharedSpec : Spec {}

    class When_inherting_from_some_shared_spec : SomeSharedSpec
    {
        void should_still_run_tests()
        {
            Specify = () => "Test".Expected().ToBe("Test");
        }
    }
}