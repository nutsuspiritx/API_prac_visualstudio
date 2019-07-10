using System;

public class Class1
{
	public Class1()
	{
        ConnectionData connectionData = new ConnectionData()
        {
            User = "Preuksa\\admin.crm",
            Password = "Pruks@2016",
            ServerAddress = "crmqa.pruksa.com",
            OrganizationName = "CRMQA",
            IsO365Org = false,
            SSL = true
        };

        var service = ConnectionThreadSafe.GetOrganizationProxy(connectionData);
    }
}
