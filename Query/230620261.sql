SELECT @@SERVERNAME

SELECT local_net_address, local_tcp_port
FROM sys.dm_exec_connections
WHERE session_id = @@SPID;

EXEC xp_readerrorlog 0, 1, N'Server is listening on';

EXEC xp_readerrorlog 0,1,N'Server is listening on';

EXEC xp_readerrorlog 0,1,N'Server local connection provider';
EXEC xp_readerrorlog 0,1,N'Server is listening on';

SELECT
    SERVERPROPERTY('InstanceName') AS InstanceName,
    SERVERPROPERTY('Edition') AS Edition,
    SERVERPROPERTY('ProductVersion') AS ProductVersion,
    SERVERPROPERTY('IsLocalDB') AS IsLocalDB;
	SELECT
SERVERPROPERTY('IsIntegratedSecurityOnly') AS IsIntegratedSecurityOnly;