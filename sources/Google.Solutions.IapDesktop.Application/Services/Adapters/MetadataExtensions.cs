﻿//
// Copyright 2020 Google LLC
//
// Licensed to the Apache Software Foundation (ASF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The ASF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
//

using Google.Apis.Compute.v1.Data;
using Google.Solutions.Common.Util;
using System;
using System.Linq;

namespace Google.Solutions.IapDesktop.Application.Services.Adapters
{
    public static class MetadataExtensions
    {

        public static Metadata.ItemsData GetItem(this Metadata metadata, string key)
        {
            return metadata?.Items
                .EnsureNotNull()
                .FirstOrDefault(item => 
                    item.Key != null && 
                    item.Key.Equals(key, StringComparison.OrdinalIgnoreCase));
        }

        public static string GetValue(this Metadata metadata, string key)
        {
            return GetItem(metadata, key)?.Value;
        }
    }
}
