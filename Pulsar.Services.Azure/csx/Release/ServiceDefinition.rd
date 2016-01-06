<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="Pulsar.Services.Azure" generation="1" functional="0" release="0" Id="2961e63e-9bd2-4668-8b7e-1f717d6675c6" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="Pulsar.Services.AzureGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="Pulsar.Services.Rest:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/LB:Pulsar.Services.Rest:Endpoint1" />
          </inToChannel>
        </inPort>
        <inPort name="Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint" protocol="tcp">
          <inToChannel>
            <lBChannelMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/LB:Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint" />
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
        <inPort name="Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint" protocol="tcp">
          <inToChannel>
            <lBChannelMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/LB:Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="Certificate|Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapCertificate|Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
          </maps>
        </aCS>
        <aCS name="Certificate|Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.TransportValidation" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapCertificate|Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.TransportValidation" />
          </maps>
        </aCS>
        <aCS name="Certificate|Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapCertificate|Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
          </maps>
        </aCS>
        <aCS name="Certificate|Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.TransportValidation" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapCertificate|Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.TransportValidation" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Rest:CloudToolsDiagnosticAgentVersion" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Rest:CloudToolsDiagnosticAgentVersion" />
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
        <aCS name="Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.ClientThumbprint" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.ClientThumbprint" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Enabled" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Enabled" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Version" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Version" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.ServerThumbprint" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.ServerThumbprint" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Rest:Profiling.ProfilingConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Rest:Profiling.ProfilingConnectionString" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.RestInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.RestInstances" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Soap:CloudToolsDiagnosticAgentVersion" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Soap:CloudToolsDiagnosticAgentVersion" />
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
        <aCS name="Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.ClientThumbprint" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.ClientThumbprint" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Enabled" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Enabled" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Version" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Version" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.ServerThumbprint" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.ServerThumbprint" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.Soap:Profiling.ProfilingConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.Soap:Profiling.ProfilingConnectionString" />
          </maps>
        </aCS>
        <aCS name="Pulsar.Services.SoapInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/MapPulsar.Services.SoapInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <sFSwitchChannel name="IE:Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector">
          <toPorts>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector" />
          </toPorts>
        </sFSwitchChannel>
        <sFSwitchChannel name="IE:Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.FileUpload">
          <toPorts>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.RemoteDebugger.FileUpload" />
          </toPorts>
        </sFSwitchChannel>
        <sFSwitchChannel name="IE:Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.Forwarder">
          <toPorts>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.RemoteDebugger.Forwarder" />
          </toPorts>
        </sFSwitchChannel>
        <sFSwitchChannel name="IE:Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector">
          <toPorts>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector" />
          </toPorts>
        </sFSwitchChannel>
        <sFSwitchChannel name="IE:Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.FileUpload">
          <toPorts>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteDebugger.FileUpload" />
          </toPorts>
        </sFSwitchChannel>
        <sFSwitchChannel name="IE:Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.Forwarder">
          <toPorts>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteDebugger.Forwarder" />
          </toPorts>
        </sFSwitchChannel>
        <lBChannel name="LB:Pulsar.Services.Rest:Endpoint1">
          <toPorts>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Endpoint1" />
          </toPorts>
        </lBChannel>
        <lBChannel name="LB:Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint">
          <toPorts>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint" />
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
        <lBChannel name="LB:Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint">
          <toPorts>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint" />
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
        <map name="MapCertificate|Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.TransportValidation" kind="Identity">
          <certificate>
            <certificateMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.RemoteDebugger.TransportValidation" />
          </certificate>
        </map>
        <map name="MapCertificate|Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" kind="Identity">
          <certificate>
            <certificateMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
          </certificate>
        </map>
        <map name="MapCertificate|Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.TransportValidation" kind="Identity">
          <certificate>
            <certificateMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteDebugger.TransportValidation" />
          </certificate>
        </map>
        <map name="MapPulsar.Services.Rest:CloudToolsDiagnosticAgentVersion" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/CloudToolsDiagnosticAgentVersion" />
          </setting>
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
        <map name="MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.ClientThumbprint" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.RemoteDebugger.ClientThumbprint" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Enabled" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Enabled" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Version" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Version" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.RemoteDebugger.ServerThumbprint" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.RemoteDebugger.ServerThumbprint" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Rest:Profiling.ProfilingConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Profiling.ProfilingConnectionString" />
          </setting>
        </map>
        <map name="MapPulsar.Services.RestInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.RestInstances" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Soap:CloudToolsDiagnosticAgentVersion" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/CloudToolsDiagnosticAgentVersion" />
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
        <map name="MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.ClientThumbprint" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteDebugger.ClientThumbprint" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Enabled" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Enabled" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Version" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Version" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteDebugger.ServerThumbprint" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteDebugger.ServerThumbprint" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" />
          </setting>
        </map>
        <map name="MapPulsar.Services.Soap:Profiling.ProfilingConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Profiling.ProfilingConnectionString" />
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
          <role name="Pulsar.Services.Rest" generation="1" functional="0" release="0" software="C:\Users\nicolasm\Source\Workspaces\Pulsar\Pulsar.Data\Pulsar.Services.Azure\csx\Release\roles\Pulsar.Services.Rest" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="-1" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
              <inPort name="Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint" protocol="tcp" portRanges="8172" />
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
              <aCS name="CloudToolsDiagnosticAgentVersion" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteDebugger.ClientThumbprint" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Enabled" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Version" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteDebugger.ServerThumbprint" defaultValue="" />
              <aCS name="Profiling.ProfilingConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;Pulsar.Services.Rest&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;Pulsar.Services.Rest&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteDebugger.FileUpload&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteDebugger.Forwarder&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;Pulsar.Services.Soap&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteDebugger.FileUpload&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteDebugger.Forwarder&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
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
              <storedCertificate name="Stored1Microsoft.WindowsAzure.Plugins.RemoteDebugger.TransportValidation" certificateStore="My" certificateLocation="System">
                <certificate>
                  <certificateMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest/Microsoft.WindowsAzure.Plugins.RemoteDebugger.TransportValidation" />
                </certificate>
              </storedCertificate>
            </storedcertificates>
            <certificates>
              <certificate name="Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
              <certificate name="Microsoft.WindowsAzure.Plugins.RemoteDebugger.TransportValidation" />
            </certificates>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.RestInstances" />
            <sCSPolicyUpdateDomainMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.RestUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.RestFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
        <groupHascomponents>
          <role name="Pulsar.Services.Soap" generation="1" functional="0" release="0" software="C:\Users\nicolasm\Source\Workspaces\Pulsar\Pulsar.Data\Pulsar.Services.Azure\csx\Release\roles\Pulsar.Services.Soap" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="-1" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="8080" />
              <inPort name="Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput" protocol="tcp" />
              <inPort name="Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint" protocol="tcp" portRanges="8172" />
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
              <aCS name="CloudToolsDiagnosticAgentVersion" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteDebugger.ClientThumbprint" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Enabled" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector.Version" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteDebugger.ServerThumbprint" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" defaultValue="" />
              <aCS name="Profiling.ProfilingConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;Pulsar.Services.Soap&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;Pulsar.Services.Rest&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteDebugger.FileUpload&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteDebugger.Forwarder&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;Pulsar.Services.Soap&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteDebugger.FileUpload&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteDebugger.Forwarder&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
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
              <storedCertificate name="Stored1Microsoft.WindowsAzure.Plugins.RemoteDebugger.TransportValidation" certificateStore="My" certificateLocation="System">
                <certificate>
                  <certificateMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap/Microsoft.WindowsAzure.Plugins.RemoteDebugger.TransportValidation" />
                </certificate>
              </storedCertificate>
            </storedcertificates>
            <certificates>
              <certificate name="Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
              <certificate name="Microsoft.WindowsAzure.Plugins.RemoteDebugger.TransportValidation" />
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
    <implementation Id="2b3eec0a-96ba-42a9-9224-8f7a42689b63" ref="Microsoft.RedDog.Contract\ServiceContract\Pulsar.Services.AzureContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="fa73dd5b-df51-4573-a73a-d2fdf7355d7c" ref="Microsoft.RedDog.Contract\Interface\Pulsar.Services.Rest:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest:Endpoint1" />
          </inPort>
        </interfaceReference>
        <interfaceReference Id="0757047b-78d3-46e8-b97b-8ee81940706d" ref="Microsoft.RedDog.Contract\Interface\Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Rest:Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint" />
          </inPort>
        </interfaceReference>
        <interfaceReference Id="898a939d-d293-4203-9552-23b4aeaaf484" ref="Microsoft.RedDog.Contract\Interface\Pulsar.Services.Soap:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap:Endpoint1" />
          </inPort>
        </interfaceReference>
        <interfaceReference Id="1c8d720c-14fd-4e16-8f37-77e5c7ddd222" ref="Microsoft.RedDog.Contract\Interface\Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput" />
          </inPort>
        </interfaceReference>
        <interfaceReference Id="2f4e97c7-bcba-4af5-95b4-1bdbc0b3a998" ref="Microsoft.RedDog.Contract\Interface\Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Pulsar.Services.Azure/Pulsar.Services.AzureGroup/Pulsar.Services.Soap:Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>