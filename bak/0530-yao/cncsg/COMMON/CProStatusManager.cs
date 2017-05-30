namespace cn.csg.dpcp.common
{
    /// <summary>
    /// 管理工程状态
    /// </summary>
    public class CProStatusManager
    {
        private static ProjectStatusEnum status = ProjectStatusEnum.CLOSE;

        public static void DoOpen()
        {
            status = ProjectStatusEnum.OPEN;
        }

        public static void DoClose()
        {
            status = ProjectStatusEnum.CLOSE;
        }

        public static void DoSaved()
        {
            status = ProjectStatusEnum.SAVED;
        }

        public static bool IsNeedSave()
        {
            return status == ProjectStatusEnum.OPEN;
        }

        public static bool IsOpen()
        {
            return status == ProjectStatusEnum.OPEN;
        }

        public static bool IsClose()
        {
            return status == ProjectStatusEnum.CLOSE;
        }

        public static bool IsSaved()
        {
            return status == ProjectStatusEnum.SAVED;
        }

        enum ProjectStatusEnum
        {

            OPEN = 2,
            SAVED = 3,
            CLOSE = 4
        }

    }
}
