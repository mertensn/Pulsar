<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="Pulsar.Services.Azure" generation="1" functional="0" release="0" Id="2d0ca770-4690-4370-a7cd-f7c3e4b29bd3" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="Pulsar.Services.AzureGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="Pulsar.Services.Rest:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/LB:Pulsar.Services.Rest:Endpoint1" />
          </inToChannel>
        </inPort>
        <inPort name="Pulsar.Services.Soap:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/LB:Pulsar.Services.Soap:Endpoint1" />
          </inToChannel>
        </inPort>
        <inPort name="Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput" protocol="tcp">
          <inToChannel>
            <lBChannelMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/LB:Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="Certificate|Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapCertificate|Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
          </maps>
        </aCS>
        <aCS name="Certificate|Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapCertificate|Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.RestInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.RestInstances" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.SoapInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.SoapInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:Pulsar.Services.Rest:Endpoint1">
          <toPorts>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Endpoint1" />
          </toPorts>
        </lBChannel>
        <lBChannel name="LB:Pulsar.Services.Soap:Endpoint1">
          <toPorts>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Endpoint1" />
          </toPorts>
        </lBChannel>
        <lBChannel name="LB:Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput">
          <toPorts>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput" />
          </toPorts>
        </lBChannel>
        <sFSwitchChannel name="SW:Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp">
          <toPorts>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" />
          </toPorts>
        </sFSwitchChannel>
        <sFSwitchChannel name="SW:Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp">
          <toPorts>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" />
          </toPorts>
        </sFSwitchChannel>
      </channels>
      <maps>
        <map name="MapCertificate|Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" kind="Identity">
          <certificate>
            <certificateMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
          </certificate>
        </map>
        <map name="MapCertificate|Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" kind="Identity">
          <certificate>
            <certificateMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
          </certificate>
        </map>
        <map name="MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" />
          </setting>
        </map>
        <map name="MapPulsar.Services.RestInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.RestInstances" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" />
          </setting>
        </map>
        <map name="MapPulsar.Services.SoapInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.SoapInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="Pulsar.Services.Rest" generation="1" functional="0" release="0" software="C:\Users\nicolasm\Source\Workspaces\Pulsar\Pulsar.Data\Pulsar.Services.Azure\csx\Debug\roles\Pulsar.Services.Rest" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="-1" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
              <inPort name="Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" protocol="tcp" portRanges="3389" />
              <outPort name="Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" protocol="tcp">
                <outToChannel>
                  <sFSwitchChannelMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/SW:Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" />
                </outToChannel>
              </outPort>
              <outPort name="Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" protocol="tcp">
                <outToChannel>
                  <sFSwitchChannelMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/SW:Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" />
                </outToChannel>
              </outPort>
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;Pulsar.Services.Rest&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;Pulsar.Services.Rest&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;Pulsar.Services.Soap&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
            <storedcertificates>
              <storedCertificate name="Stored0Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" certificateStore="My" certificateLocation="System">
                <certificate>
                  <certificateMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
                </certificate>
              </storedCertificate>
            </storedcertificates>
            <certificates>
              <certificate name="Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
            </certificates>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.RestInstances" />
            <sCSPolicyUpdateDomainMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.RestUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.RestFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
        <groupHascomponents>
          <role name="Pulsar.Services.Soap" generation="1" functional="0" release="0" software="C:\Users\nicolasm\Source\Workspaces\Pulsar\Pulsar.Data\Pulsar.Services.Azure\csx\Debug\roles\Pulsar.Services.Soap" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="-1" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="8080" />
              <inPort name="Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput" protocol="tcp" />
              <inPort name="Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" protocol="tcp" portRanges="3389" />
              <outPort name="Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" protocol="tcp">
                <outToChannel>
                  <sFSwitchChannelMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/SW:Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" />
                </outToChannel>
              </outPort>
              <outPort name="Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" protocol="tcp">
                <outToChannel>
                  <sFSwitchChannelMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/SW:Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" />
                </outToChannel>
              </outPort>
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;Pulsar.Services.Soap&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;Pulsar.Services.Rest&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;Pulsar.Services.Soap&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
            <storedcertificates>
              <storedCertificate name="Stored0Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" certificateStore="My" certificateLocation="System">
                <certificate>
                  <certificateMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
                </certificate>
              </storedCertificate>
            </storedcertificates>
            <certificates>
              <certificate name="Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
            </certificates>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.SoapInstances" />
            <sCSPolicyUpdateDomainMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.SoapUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.SoapFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="Pulsar.Services.SoapUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyUpdateDomain name="Pulsar.Services.RestUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="Pulsar.Services.RestFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyFaultDomain name="Pulsar.Services.SoapFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="Pulsar.Services.RestInstances" defaultPolicy="[1,1,1]" />
        <sCSPolicyID name="Pulsar.Services.SoapInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="5988158b-ed80-40fd-96fc-c76c88ed6b09" ref="Microsoft.RedDog.Contract\ServiceContract\Pulsar.Services.AzureContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="bc4981a2-a3e7-4cc7-ba99-b7b65f326dd0" ref="Microsoft.RedDog.Contract\Interface\Pulsar.Services.Rest:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest:Endpoint1" />
          </inPort>
        </interfaceReference>
        <interfaceReference Id="192cbddf-177f-4cc3-8062-64a873b945cb" ref="Microsoft.RedDog.Contract\Interface\Pulsar.Services.Soap:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap:Endpoint1" />
          </inPort>
        </interfaceReference>
        <interfaceReference Id="e84bad1e-0e09-4436-971c-328d2a0a6dba" ref="Microsoft.RedDog.Contract\Interface\Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>