﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace NewsNow
{
    class XmlParser
    {
        private string url;
        private XmlDocument doc;
        private List<Article> list;

        public XmlParser(string url)
        {
            this.url = url;
            this.doc = new XmlDocument();
            this.list = new List<Article>();
        }

        public string LatestHeadline()
        {
            doc.Load(url);

            XmlElement rootNode = doc.DocumentElement;
            XmlNodeList nodes = rootNode.SelectNodes("channel/item");

            foreach (XmlNode node in nodes)
            {
                Article article = new Article();
                article.Guid = node["guid"].InnerText;
                article.Title = node["title"].InnerText;
                article.Date = Convert.ToDateTime(node["pubDate"].InnerText);
                article.Description = node["description"].InnerText;
                try
                {
                    article.Category = (node["category"].InnerText == null) ? node["category"].InnerText : " ";
                }
                catch (NullReferenceException)
                {
                    article.Category = "null";
                }

                try
                {
                    article.HashTag = node["category"].InnerText;
                }
                catch (NullReferenceException)
                {
                    article.HashTag = "#null";
                }
                list.Add(article);
            }
            return list.First().ToString();
        }
    }
}
