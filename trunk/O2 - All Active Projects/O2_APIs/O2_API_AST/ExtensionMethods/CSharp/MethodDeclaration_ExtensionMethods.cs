﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.NRefactory.Ast;
using ICSharpCode.NRefactory;
using O2.API.AST.CSharp;
using O2.Kernel.ExtensionMethods;
using O2.DotNetWrappers.ExtensionMethods;

namespace O2.API.AST.ExtensionMethods.CSharp
{
	public static class MethodDeclaration_ExtensionMethods
	{     

        public static List<MethodDeclaration> methods(this TypeDeclaration typeDeclaration)
        {
            var methods = from child in typeDeclaration.Children
                          where child is MethodDeclaration
                          select (MethodDeclaration)child;
            return methods.ToList();
        }

        public static List<MethodDeclaration> methods(this IParser parser)
        {
            return parser.CompilationUnit.methods();
        }

        public static List<MethodDeclaration> methods(this CompilationUnit compilationUnit)
        {
            return compilationUnit.types(true).methods();
        }

        public static List<MethodDeclaration> methods(this List<TypeDeclaration> typeDeclarations)
        {
            var methods = new List<MethodDeclaration>();
            foreach (var typeDeclaration in typeDeclarations)
                methods.AddRange(typeDeclaration.methods());
            return methods;
        }

        public static MethodDeclaration method(this IParser parser, string name)
        {
            return parser.CompilationUnit.method(name);
        }

        public static MethodDeclaration method(this CompilationUnit compilationUnit, string name)
        {
            return compilationUnit.types(true).methods().method(name);
        }

        public static MethodDeclaration method(this List<MethodDeclaration> methodDeclarations, string name)
        {
            foreach (var methodDeclaration in methodDeclarations)
                if (methodDeclaration.name() == name)
                    return methodDeclaration;
            return null;
        }

        public static TypeReference returnType(this MethodDeclaration methodDeclaration)
        {
            return methodDeclaration.TypeReference;
        }

        public static List<TypeReference> returnTypes(this List<MethodDeclaration> methodDeclarations)
        {
            var returnTypes = from methodDeclaration in methodDeclarations
                              select methodDeclaration.returnType();
            return returnTypes.ToList();
        }

        public static MethodDeclaration name(this List<MethodDeclaration> methodDeclarations, string name)
        {
            return methodDeclarations.method(name);
        }

        public static string name(this MethodDeclaration methodDeclaration)
        {
            return methodDeclaration.Name;
        }

        public static List<string> names(this List<MethodDeclaration> methodDeclarations)
        {
            var names = from methodDeclaration in methodDeclarations
                          select methodDeclaration.Name;
            return names.ToList();
        }

        public static List<LocalVariableDeclaration> variables(this List<MethodDeclaration> methodDeclarations)
        {
            var variables = new List<LocalVariableDeclaration>();
            foreach (var methodDeclaration in methodDeclarations)
                variables.AddRange(methodDeclaration.variables());
            return variables;
        }

        public static List<LocalVariableDeclaration> variables(this MethodDeclaration methodDeclaration)
        {
            var astVisitors = new AstVisitors();
            methodDeclaration.AcceptVisitor(astVisitors, null);
            return astVisitors.localVariableDeclarations;
        }

        public static List<InvocationExpression> invocations(this List<MethodDeclaration> methodDeclarations)
        {
            var invocations = new List<InvocationExpression>();
            foreach (var methodDeclaration in methodDeclarations)
                invocations.AddRange(methodDeclaration.invocations());
            return invocations;
        }

        public static List<InvocationExpression> invocations(this MethodDeclaration methodDeclaration)
        {
            var astVisitors = new AstVisitors();
            methodDeclaration.AcceptVisitor(astVisitors, null);
            return astVisitors.invocationExpressions; 
        }

        public static string sourceCode(this MethodDeclaration methodDeclaration, string sourceCodeFile)
        {
            var startLine = methodDeclaration.StartLocation.Line;
            var endLine = (methodDeclaration.Body != null)
                            ? methodDeclaration.Body.EndLocation.Line
                            : startLine + 1;
            return sourceCodeFile.fileSnippet(startLine - 1, endLine);
        }
	}
}