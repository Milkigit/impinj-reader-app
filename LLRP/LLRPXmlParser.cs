
/*
***************************************************************************
*  Copyright 2007 Impinj, Inc.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
***************************************************************************
*/


/*
***************************************************************************
*
*  This code is generated by Impinj LLRP .Net generator. Modification is not
*  recommended.
*
***************************************************************************
*/

/*
***************************************************************************
* File Name:       LLRPXmlParser.cs
*
* Version:         1.0
* Author:          Impinj
* Organization:    Impinj
* Date:            Jan. 18, 2008
*
* Description:     This file contains general XML parser for LLRP messages
***************************************************************************
*/

using System;
using System.IO;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Runtime.InteropServices;

using LLRP;
using LLRP.DataType;

public class LLRPXmlParser
{
    public static void ParseXMLToLLRPMessage(string xmlstr, out object msg, out ENUM_LLRP_MSG_TYPE type)
    {
        XmlDocument xdoc = new XmlDocument();
        xdoc.LoadXml(xmlstr);
        XmlNode node = (XmlNode)xdoc.DocumentElement;

        switch (node.Name)
        {

            case "CUSTOM_MESSAGE":
                msg = (object)MSG_CUSTOM_MESSAGE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.CUSTOM_MESSAGE;
                return;

            case "GET_READER_CAPABILITIES":
                msg = (object)MSG_GET_READER_CAPABILITIES.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.GET_READER_CAPABILITIES;
                return;

            case "GET_READER_CAPABILITIES_RESPONSE":
                msg = (object)MSG_GET_READER_CAPABILITIES_RESPONSE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.GET_READER_CAPABILITIES_RESPONSE;
                return;

            case "ADD_ROSPEC":
                msg = (object)MSG_ADD_ROSPEC.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.ADD_ROSPEC;
                return;

            case "ADD_ROSPEC_RESPONSE":
                msg = (object)MSG_ADD_ROSPEC_RESPONSE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.ADD_ROSPEC_RESPONSE;
                return;

            case "DELETE_ROSPEC":
                msg = (object)MSG_DELETE_ROSPEC.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.DELETE_ROSPEC;
                return;

            case "DELETE_ROSPEC_RESPONSE":
                msg = (object)MSG_DELETE_ROSPEC_RESPONSE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.DELETE_ROSPEC_RESPONSE;
                return;

            case "START_ROSPEC":
                msg = (object)MSG_START_ROSPEC.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.START_ROSPEC;
                return;

            case "START_ROSPEC_RESPONSE":
                msg = (object)MSG_START_ROSPEC_RESPONSE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.START_ROSPEC_RESPONSE;
                return;

            case "STOP_ROSPEC":
                msg = (object)MSG_STOP_ROSPEC.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.STOP_ROSPEC;
                return;

            case "STOP_ROSPEC_RESPONSE":
                msg = (object)MSG_STOP_ROSPEC_RESPONSE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.STOP_ROSPEC_RESPONSE;
                return;

            case "ENABLE_ROSPEC":
                msg = (object)MSG_ENABLE_ROSPEC.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.ENABLE_ROSPEC;
                return;

            case "ENABLE_ROSPEC_RESPONSE":
                msg = (object)MSG_ENABLE_ROSPEC_RESPONSE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.ENABLE_ROSPEC_RESPONSE;
                return;

            case "DISABLE_ROSPEC":
                msg = (object)MSG_DISABLE_ROSPEC.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.DISABLE_ROSPEC;
                return;

            case "DISABLE_ROSPEC_RESPONSE":
                msg = (object)MSG_DISABLE_ROSPEC_RESPONSE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.DISABLE_ROSPEC_RESPONSE;
                return;

            case "GET_ROSPECS":
                msg = (object)MSG_GET_ROSPECS.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.GET_ROSPECS;
                return;

            case "GET_ROSPECS_RESPONSE":
                msg = (object)MSG_GET_ROSPECS_RESPONSE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.GET_ROSPECS_RESPONSE;
                return;

            case "ADD_ACCESSSPEC":
                msg = (object)MSG_ADD_ACCESSSPEC.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.ADD_ACCESSSPEC;
                return;

            case "ADD_ACCESSSPEC_RESPONSE":
                msg = (object)MSG_ADD_ACCESSSPEC_RESPONSE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.ADD_ACCESSSPEC_RESPONSE;
                return;

            case "DELETE_ACCESSSPEC":
                msg = (object)MSG_DELETE_ACCESSSPEC.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.DELETE_ACCESSSPEC;
                return;

            case "DELETE_ACCESSSPEC_RESPONSE":
                msg = (object)MSG_DELETE_ACCESSSPEC_RESPONSE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.DELETE_ACCESSSPEC_RESPONSE;
                return;

            case "ENABLE_ACCESSSPEC":
                msg = (object)MSG_ENABLE_ACCESSSPEC.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.ENABLE_ACCESSSPEC;
                return;

            case "ENABLE_ACCESSSPEC_RESPONSE":
                msg = (object)MSG_ENABLE_ACCESSSPEC_RESPONSE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.ENABLE_ACCESSSPEC_RESPONSE;
                return;

            case "DISABLE_ACCESSSPEC":
                msg = (object)MSG_DISABLE_ACCESSSPEC.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.DISABLE_ACCESSSPEC;
                return;

            case "DISABLE_ACCESSSPEC_RESPONSE":
                msg = (object)MSG_DISABLE_ACCESSSPEC_RESPONSE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.DISABLE_ACCESSSPEC_RESPONSE;
                return;

            case "GET_ACCESSSPECS":
                msg = (object)MSG_GET_ACCESSSPECS.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.GET_ACCESSSPECS;
                return;

            case "GET_ACCESSSPECS_RESPONSE":
                msg = (object)MSG_GET_ACCESSSPECS_RESPONSE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.GET_ACCESSSPECS_RESPONSE;
                return;

            case "GET_READER_CONFIG":
                msg = (object)MSG_GET_READER_CONFIG.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.GET_READER_CONFIG;
                return;

            case "GET_READER_CONFIG_RESPONSE":
                msg = (object)MSG_GET_READER_CONFIG_RESPONSE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.GET_READER_CONFIG_RESPONSE;
                return;

            case "SET_READER_CONFIG":
                msg = (object)MSG_SET_READER_CONFIG.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.SET_READER_CONFIG;
                return;

            case "SET_READER_CONFIG_RESPONSE":
                msg = (object)MSG_SET_READER_CONFIG_RESPONSE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.SET_READER_CONFIG_RESPONSE;
                return;

            case "CLOSE_CONNECTION":
                msg = (object)MSG_CLOSE_CONNECTION.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.CLOSE_CONNECTION;
                return;

            case "CLOSE_CONNECTION_RESPONSE":
                msg = (object)MSG_CLOSE_CONNECTION_RESPONSE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.CLOSE_CONNECTION_RESPONSE;
                return;

            case "GET_REPORT":
                msg = (object)MSG_GET_REPORT.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.GET_REPORT;
                return;

            case "RO_ACCESS_REPORT":
                msg = (object)MSG_RO_ACCESS_REPORT.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.RO_ACCESS_REPORT;
                return;

            case "KEEPALIVE":
                msg = (object)MSG_KEEPALIVE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.KEEPALIVE;
                return;

            case "KEEPALIVE_ACK":
                msg = (object)MSG_KEEPALIVE_ACK.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.KEEPALIVE_ACK;
                return;

            case "READER_EVENT_NOTIFICATION":
                msg = (object)MSG_READER_EVENT_NOTIFICATION.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.READER_EVENT_NOTIFICATION;
                return;

            case "ENABLE_EVENTS_AND_REPORTS":
                msg = (object)MSG_ENABLE_EVENTS_AND_REPORTS.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.ENABLE_EVENTS_AND_REPORTS;
                return;

            case "ERROR_MESSAGE":
                msg = (object)MSG_ERROR_MESSAGE.FromString(xmlstr);
                type = ENUM_LLRP_MSG_TYPE.ERROR_MESSAGE;
                return;

            default:
                msg = null;
                type = 0;
                return;
        }
    }
}