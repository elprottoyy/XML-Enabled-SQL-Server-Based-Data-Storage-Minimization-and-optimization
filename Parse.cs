
XmlDocument doc = new XmlDocument();  //XmlDocument class to load the XML document into memory
doc.Load("/path/to/file.xml");
XmlNodeList nodes = doc.SelectNodes("/root/element"); /* SelectNodes method of the XmlDocument to select specific elements */
foreach (XmlNode node in nodes) {
  // Process the node
}
XmlNodeList nodes = doc.SelectNodes("/root/element");
foreach (XmlNode node in nodes) {
  // Process the node
}
string text = node.InnerText;  // InnerText or InnerXml properties of the XmlNode to access the nodes 
string xml = node.InnerXml;

XmlAttributeCollection attributes = node.Attributes;  /* Attributes property of the XmlNode to access the attributes of an element */
string attributeValue = attributes["attributeName"].Value;

XmlElement newElement = doc.CreateElement("newElement");  /*  CreateElement and AppendChild methods of the XmlDocument to create and add new elements to the document */
newElement.InnerText = "new element value";
doc.DocumentElement.AppendChild(newElement);


doc.Save("/path/to/modified_file.xml");  /* Save method of the XmlDocument to save the modified document to a file */



