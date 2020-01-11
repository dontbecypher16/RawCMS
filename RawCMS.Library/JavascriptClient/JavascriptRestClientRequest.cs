﻿//******************************************************************************
// <copyright file="license.md" company="RawCMS project  (https://github.com/arduosoft/RawCMS)">
// Copyright (c) 2019 RawCMS project  (https://github.com/arduosoft/RawCMS)
// RawCMS project is released under GPL3 terms, see LICENSE file on repository root at  https://github.com/arduosoft/RawCMS .
// </copyright>
// <author>Daniele Fontani, Emanuele Bucarelli, Francesco Mina'</author>
// <autogenerated>true</autogenerated>
//******************************************************************************
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;

namespace RawCMS.Library.JavascriptClient
{
    public class JavascriptRestClientRequest
    {
        public string Url { get; set; }
        public Dictionary<string,string> Header { get; set; }
        public Dictionary<string,string> QueryParams { get; set; }
        public string  Method { get; set; }
        public JObject Body { get; set; }
    }
}