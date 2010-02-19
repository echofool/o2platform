﻿using System;
using System.Collections;
using System.Collections.Generic;
using O2.DotNetWrappers.DotNet;
using O2.Kernel.ExtensionMethods;

namespace O2.DotNetWrappers.ExtensionMethods
{
    public static class Collections_ExtensionMethods
    {
        public static string toString<T>(this IEnumerable<T> sequence) where T : class
        {
            var value = "";
            foreach (var item in sequence)
            {
                if (value.valid())
                    value += " , ";
                value += " \"{0}\"".format(item != null ? item.ToString() : "");
            }
            value = "{{ {0} }}".format(value);
            return value;
        }

        public static void ForEach<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            foreach (T item in sequence)
                action(item);
        }

        public static void add<T>(this List<T> sequence, params object[] values)
        {
            var t = (T)typeof(T).ctor();
            var properties = t.type().properties();
            Loop.nTimes(values.Length, i => t.prop(properties[i], values[i]));            
            sequence.Add(t);
        }

        public static int size(this ICollection colection)
        {
            return colection.Count;
        }

        public static bool size(this ICollection colection, int value)
        {
            return colection.size() == value;
        }


        public static List<string> lines(this string targetString)
        {
            return StringsAndLists.fromTextGetLines(targetString);
        }

        public static List<string> split_onLines(this string targetString)
        {
            return targetString.split(Environment.NewLine);
        }

        public static List<string> split_onSpace(this string targetString)
        {
            return targetString.split(" ");
        }

        public static List<string> split(this string targetString, string splitString)
        {
            var result = new List<string>();
            var splittedString = targetString.Split(new[] { splitString }, StringSplitOptions.None);
            result.AddRange(splittedString);
            return result;
        }

        public static List<List<string>> split_onSpace(this List<string> list)
        {
            return list.split(" ");
        }
        public static List<List<string>> split(this List<string> list, string splitString)
        {
            var result = new List<List<string>>();
            foreach (var item in list)
                result.Add(item.split(splitString));
            return result;
        }

        public static List<T> add<T>(this List<T> list, T item)
        {
            list.Add(item);
            return list;
        }

        public static List<object> values(this Dictionary<string, object> dictionary)
        {
            var results = new List<object>();
            results.AddRange(dictionary.Values);
            return results;
        }
        public static object[] valuesArray(this Dictionary<string, object> dictionary)
        {
            return dictionary.values().ToArray();
        }
    }
}