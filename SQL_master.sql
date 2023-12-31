USE [master]
GO
/****** Object:  StoredProcedure [dbo].[sp_DAILYBACKUP]    Script Date: 7/16/2023 7:12:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_DAILYBACKUP] 
@PATH NVARCHAR(150), @TIME NVARCHAR(10)
AS
BEGIN
DECLARE @DATE nvarchar(15) = (SELECT CONVERT(NVARCHAR, GETDATE(), 112))
set @TIME=@TIME +'00';
DECLARE @DATETIME NVARCHAR(50)= @DATE+'_' + @TIME
DECLARE @COMMAND NVARCHAR(150)='EXEC MUAHEXANH.dbo.sp_fullbackup'+' '+'''' +@PATH +''''+','+''''+'DB_MUAHEXANH_'+@DATETIME+'_AUTO'+''''
EXEC msdb.dbo.sp_delete_job
   @job_name = N'DailyBackup';

EXEC msdb.dbo.sp_add_job  
    @job_name = N'DailyBackup' ; 
	
EXEC msdb.dbo.sp_add_jobstep  
    @job_name = N'DailyBackup',  
    @step_name = N'DailyBackup',  
    @subsystem = N'TSQL',  
    @command = @COMMAND,   
    @retry_attempts = 1   

DECLARE @schedule_id INT
EXEC msdb.dbo.sp_add_schedule
        @schedule_name = N'DailyBackup',
        @enabled = 1,
        @freq_type = 4,
        @freq_interval = 1,
        @active_start_time = @TIME,
        @schedule_id = @schedule_id OUTPUT;
EXEC msdb.dbo.sp_attach_schedule
        @job_name = N'DailyBackup',
        @schedule_id = @schedule_id;
EXEC msdb.dbo.sp_add_jobserver
		@job_name=N'DailyBackup'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_differentialrestore]    Script Date: 7/16/2023 7:12:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_differentialrestore] (@path1 varchar(1000),@path2 varchar(1000))
-- @path1 is fullrestore 
-- @path2 is diffrestore
as  
ALTER DATABASE MUAHEXANH 
SET OFFLINE WITH ROLLBACK IMMEDIATE
RESTORE DATABASE MUAHEXANH FROM DISK = @path1
WITH NORECOVERY, replace
RESTORE DATABASE MUAHEXANH FROM DISK = @path2
ALTER DATABASE MUAHEXANH
SET ONLINE
GO
/****** Object:  StoredProcedure [dbo].[sp_fullrestore]    Script Date: 7/16/2023 7:12:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_fullrestore] (@filename varchar(1000))
as 
ALTER DATABASE MUAHEXANH 
SET OFFLINE WITH ROLLBACK IMMEDIATE
RESTORE DATABASE MUAHEXANH FROM disk = @filename
WITH REPLACE
ALTER DATABASE MUAHEXANH 
SET ONLINE
GO
/****** Object:  StoredProcedure [dbo].[sp_WEEKLYBACKUP]    Script Date: 7/16/2023 7:12:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_WEEKLYBACKUP] 
@PATH NVARCHAR(150), @TIME NVARCHAR(10), @DAY INT
AS
BEGIN
DECLARE @DATE nvarchar(15) = (SELECT CONVERT(NVARCHAR, GETDATE(), 112))
set @TIME=@TIME +'00';
DECLARE @DATETIME NVARCHAR(50)= @DATE+'_' + @TIME
DECLARE @COMMAND NVARCHAR(150)='EXEC MUAHEXANH.dbo.sp_fullbackup'+' '+'''' +@PATH +''''+','+''''+'DB_MUAHEXANH_'+@DATETIME+'_AUTO'+''''
EXEC msdb.dbo.sp_delete_job
   @job_name = N'WeeklyBackup';

EXEC msdb.dbo.sp_add_job  
    @job_name = N'WeeklyBackup' ; 
	
EXEC msdb.dbo.sp_add_jobstep  
    @job_name = N'WeeklyBackup',  
    @step_name = N'WeeklyBackup',  
    @subsystem = N'TSQL',  
    @command = @COMMAND,   
    @retry_attempts = 1   

DECLARE @schedule_id INT
EXEC msdb.dbo.sp_add_schedule
        @schedule_name = N'WeeklyBackup',
        @enabled = 1,
        @freq_type = 8,
        @freq_interval = @DAY,
		@freq_recurrence_factor = 1,
        @active_start_time = @TIME,
        @schedule_id = @schedule_id OUTPUT;
		
EXEC msdb.dbo.sp_attach_schedule
        @job_name = N'WeeklyBackup',
        @schedule_id = @schedule_id;
EXEC msdb.dbo.sp_add_jobserver
		@job_name=N'WeeklyBackup'
END
GO
