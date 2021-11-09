﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _18_Timer

{
    class XMLControl
    {
        public static string _TICK = "TICK";
        public static string _TOTAL = "TOTAL";
        public static string _LEVEL_1 = "LEVEL_1";
        public static string _LEVEL_3 = "LEVEL_3";
        public static string _LEVEL_50 = "LEVEL_50";
        
        /// <summary>
        /// 읽어오기
        /// </summary>
        /// <param name="strXMLPath"></param>
        /// <returns></returns>
        public Dictionary<string, string> fXML_Reader(string strXMLPath)
        {

            Dictionary<string, string> DXMLConfig = new Dictionary<string, string>();
            using(XmlReader rd = XmlReader.Create(strXMLPath))
            {
                while (rd.Read())
                {
                    if (rd.IsStartElement())
                    {
                        if (rd.Name.Equals("SETTING"))
                        {
                            string strID = rd["ID"];
                            rd.Read();

                            string strTICK = rd.ReadElementContentAsString(_TICK, "");
                            DXMLConfig.Add(_TICK, strTICK);

                            string strTOTAL = rd.ReadElementContentAsString(_TOTAL, "");
                            DXMLConfig.Add(_TOTAL, strTOTAL);

                            string strLEVEL1 = rd.ReadElementContentAsString(_LEVEL_1, "");
                            DXMLConfig.Add(_LEVEL_1, strLEVEL1);

                            string strLEVEL3 = rd.ReadElementContentAsString(_LEVEL_3, "");
                            DXMLConfig.Add(_LEVEL_3, strLEVEL3);

                            string strLEVEL50 = rd.ReadElementContentAsString(_LEVEL_50, "");
                            DXMLConfig.Add(_LEVEL_50, strLEVEL50);
                        }
                    }
                }
            }

            return DXMLConfig;
        }
        
        /// <summary>
        /// 저장하기
        /// </summary>
        /// <param name="strXMLPath"></param>
        /// <param name="DXMLConfig"></param>
        public void fXML_Writer(string strXMLPath, Dictionary<string, string> DXMLConfig)
        {
            using (XmlWriter wr = XmlWriter.Create(strXMLPath))
            {
                wr.WriteStartDocument();

                //SETTING
                wr.WriteStartElement("SETTING");
                wr.WriteAttributeString("ID", "0001");

                wr.WriteElementString(_TICK, DXMLConfig[_TICK]);
                wr.WriteElementString(_TOTAL, DXMLConfig[_TOTAL]);
                wr.WriteElementString(_LEVEL_1, DXMLConfig[_LEVEL_1]);
                wr.WriteElementString(_LEVEL_3, DXMLConfig[_LEVEL_3]);
                wr.WriteElementString(_LEVEL_50, DXMLConfig[_LEVEL_50]);

                wr.WriteEndElement();
                wr.WriteEndDocument();

            }
        }
    }
}
