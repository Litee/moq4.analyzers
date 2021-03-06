﻿namespace Moq.Analyzers.Test
{
    using System.IO;
    using ApprovalTests;
    using ApprovalTests.Reporters;
    using Microsoft.CodeAnalysis.Diagnostics;
    using TestHelper;
    using Xunit;

    [UseReporter(typeof(DiffReporter))]
    public class SetupShouldBeUsedOnlyForOverridableMembersAnalyzerTests : DiagnosticVerifier
    {
        [Fact]
        public void ShouldPassIfGoodParameters()
        {
            Approvals.Verify(VerifyCSharpDiagnostic(File.ReadAllText("Data/SetupOnlyForOverridableMembers.cs")));
        }

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new SetupShouldBeUsedOnlyForOverridableMembersAnalyzer();
        }
    }
}