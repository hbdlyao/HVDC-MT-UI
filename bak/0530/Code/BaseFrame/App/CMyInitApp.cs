///////////////////////////////////////////////////////////
//  CMyInitApp.cs
//  Implementation of the Class CMyInitApp
//  Generated by Enterprise Architect
//  Created on:      09-5月-2017 16:15:35
//  Original author: open2
///////////////////////////////////////////////////////////

namespace Yao.BaseFrame.App
{
    /// <summary>
    /// 程序初始化
    /// </summary>
    public static class CMyInitApp
    {
        public static void Clear()
        {
            CMyParams.Clear();

            CMyVars.Clear();
            //
            CMyMvcs.Clear();

        }

        public static void Release()
        {

            //清空数据表
            //CMyParams.Release();

            CMyVars.Release();
            CMyMvcs.Release();
        }

        public static void Init()
        {
            CMyParams.Init();

            CMyVars.Init();
            //
            CMyMvcs.Init();

        }

        public static void Close()
        {
            //
            Save();

            //
            Clear();

        }

        public static void Exit()
        {
            //
            Save();

            //
            Release();

        }

        public static bool New()
        {
            bool vOk = true;
            return vOk;
            /*
			vOk=gbShowMvc.ShowNew();
			if vOk then
			begin
			gbcfg.IsEditing=true;
			end;
	
			Result=vOk;
			*/
        }

        public static bool ReOpen()
        {
            bool vOk = false;
            //关闭现有工程
            Close();

            //初始化工程
            //ReInit();

            //重新打开选定工程
            vOk = Open();

            return vOk;
        }

        public static bool ReNew()
        {

            bool vOk = false;

            //关闭现有工程
            Close();

            //初始化工程
            //ReInit();

            //重新打开选定工程
            vOk = New();

            return vOk;
        }

        public static bool Open()
        {
            bool vOk = true;

            //
            CMyMvcs.OnLoad();

            //
            return vOk;
            /*
			vOk=gbShowMvc.ShowOpen();//svag
	
			if vOk then
			begin
			vFile=gbCfg.PRJFile;
			//
			gbPRJMVC.OnLoad();
			//
			gbRw.OnLoad();
	
			gbCfg.IsExist=true;
			gbcfg.IsEditing=true;
	
			end;
	
			Result=vOk;
			*/
        }

        public static bool Save()
        {

            bool vOk = true;

            CMyMvcs.OnSave();

            return vOk;
            /*
	
			if gbCfg.IsExist then
			vOk=gbShowMvc.ShowSave()
			else
			vOk=gbShowMvc.ShowSaveAs();
	
			/////////////////////
			if vOk then
			begin
			vFile=gbCfg.PRJFile;
			if not FileExists(vFile) then
			NewPRJFile(vFile);
	
			//
			gbPrjMvc.OnSave();
			//
			//gbRw.OnSave();    //2013-4-3 by yao
	
			//
			gbCfg.IsExist=true;
	
			end;
	
			result=vOk;
			*/
        }

        public static bool SaveAs()
        {

            bool vOk = true;

            //
            CMyMvcs.OnSave();


            return vOk;
            /*
			vOk=gbShowMvc.ShowSaveAs();
			if vOk then
			begin
			vFile=gbCfg.PRJFile;
			if not FileExists(vFile) then
			NewPRJFile(vFile);
			//
			gbPrjMvc.OnSave(vFile);
			//
			gbRw.OnSave();
	
			end;
	
			result=vOk;
			*/
        }

        public static bool IsSave()
        {

            bool vOk = true;
            return vOk;
            /*
			if gbPrjMvc.IsEditing then
			begin
			vRes=msg_Question('将要退出程序，是否保存数据？');//,'提示',MB_DEFBUTTON1);
	
			case vRes of
			mrYes   :   gbCFG.IsContinue=true;
			mrNo     :  gbCFG.IsContinue=true;
			mrCancel :  gbCFG.IsContinue=false;
			end;
	
			end;//if
	
			//
			result=(vRes=mrYes);
			*/
        }

        /// 
        /// <param name="vID"></param>
        public static void Help(int vID)
        {

            //vStr=gbcfg.helpPath+'Hvdc.hlp';
            //WinHelp(Application.MainForm.Handle,PChar(vStr),HELP_CONTEXT,vID);
        }

    }//end CMyInitApp

}//end namespace BaseFrame