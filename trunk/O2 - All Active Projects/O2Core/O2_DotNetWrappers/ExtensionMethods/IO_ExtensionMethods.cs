﻿using System;
using System.Collections.Generic;
using System.IO;
using O2.DotNetWrappers.Windows;
using O2.Kernel.ExtensionMethods;

namespace O2.DotNetWrappers.ExtensionMethods
{
    public static class IO_ExtensionMethods
    {
        public static string fileName(this string file)
        {
            if (file.valid())
                return Path.GetFileName(file);
            return "";
        }

        public static string directoryName(this string file)
        {
            if (file.valid())
                return Path.GetDirectoryName(file);
            return "";            
        }

        public static string extension(this string file)
        {
            if (file.valid())
                return Path.GetExtension(file).ToLower();
            return "";
        }

        public static bool extension(this string file, string extension)
        {
            if (file.valid())
                return file.extension() == extension;
            return false;
        }

        public static bool exists(this string file)
        {
            if (file.valid())
                return file.fileExists() || file.dirExists();
            return false;
        }

        public static bool isFile(this string path)
        {
            return path.fileExists();
        }

        public static bool isImage(this string path)
        {
            switch (path.extension())
            { 
                case ".gif":
                case ".jpg":
                case ".jpeg":
                case ".bmp":
                case ".png":
                    return true;
                default:
                    return false;
            }
        }

        public static bool isText(this string path)
        {
            switch (path.extension())
            {
                case ".txt":                
                    return true;
                default:
                    return false;
            }
        }

        public static bool isDocument(this string path)
        {
            switch (path.extension())
            {
                case ".rtf":
                case ".doc":
                    return true;
                default:
                    return false;
            }
        }

        public static bool fileExists(this string file)
        {
            if (file.valid())
                return File.Exists(file);
            return false;
        }

        public static bool isFolder(this string path)
        {
            return path.dirExists();
        }

        public static bool dirExists(this string path)
        {
            if (path.valid())
                return Directory.Exists(path);
            return false;
        }

        public static void create(this string file, string fileContents)
        {
            if (file.valid())
                Files.WriteFileContent(file, fileContents);            
        }

        public static string fileContents(this string file)
        {
            return file.contents();
        }

        public static string contents(this string file)
        {
            if (file.valid())
                return Files.getFileContents(file);
            return "";
        }

        public static byte[] contentsAsBytes(this string file)
        {
            if (file.fileExists())
                return Files.getFileContentsAsByteArray(file);
            return null;
        }

        public static bool fileWrite(this string file, string fileContents)
        {
            return Files.WriteFileContent(file, fileContents);
        }

        public static List<T> wrapOnList<T>(this T item)
        {
            var list = new List<T>();
            list.add(item);
            return list;
        }

        public static List<string> files(this string path)
        {
            return path.files("", false);
        }

        public static List<string> files(this string path, string  searchPattern)
        {
            return path.files(searchPattern, false);
        }

        public static List<string> files(this string path, string searchPatterns, bool recursive)
        {
            return path.files(searchPatterns.wrapOnList(), recursive);
        }

        public static List<string> files(this string path, List<string> searchPatterns)
        {
            return path.files(searchPatterns, false);
        }       

        public static List<string> files(this string path, List<string> searchPatterns, bool recursive)
        {
            return (path.isFolder()) 
                ? Files.getFilesFromDir_returnFullPath(path, searchPatterns, recursive)
                : new List<string>();
        }


        public static List<string> dirs(this string path)
        {
            return path.folders(false);
        }

        public static List<string> folders(this string path)
        {
            return path.folders(false);
        }

        public static List<string> folders(this string path, bool recursive)
        {
            return (path.isFolder())
                ? Files.getListOfAllDirectoriesFromDirectory(path, recursive)
                : new List<string>();
        }

        public static string pathCombine(this string folder, string file)
        {
            if (file.StartsWith("/"))           // need to remove a leading '/' or the Path.Combine doesn't work properly
                file = file.Substring(1);
            return Path.Combine(folder, file).fullPath();
        }

        public static string fullPath(this string path)
        {
            return Path.GetFullPath(path);
        }
        public static void createDir(this string directory)
        {
            Files.checkIfDirectoryExistsAndCreateIfNot(directory);
        }

        public static void createFolder(this string folder)
        {
            folder.createDir();
        }
    }
}