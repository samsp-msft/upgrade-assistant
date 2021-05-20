﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.DotNet.UpgradeAssistant.Extensions.Default.Analyzers;

namespace Microsoft.DotNet.UpgradeAssistant.Extensions.Default.CodeFixes
{
    [ApplicableComponents(ProjectComponents.AspNetCore)]
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = "UA0009 CodeFix Provider")]
    public class HelperResultCodeFixer : IdentifierUpgradeCodeFixer
    {
        public override string CodeFixTitle => CodeFixResources.HelperResultTitle;

        public override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(HelperResultAnalyzer.DiagnosticId);
    }
}