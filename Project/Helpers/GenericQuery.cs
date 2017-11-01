using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Helpers
{
    public class GenericQuery
    {
        // return Model
        public static int ExecSQLCommand(string Query, object[] Param = null)
        {
            using (var ctx = new indomodaEntities())
            {
                int queryExec = 0;
                using (var db = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        if (Param == null)
                        {
                            queryExec = ctx.Database.ExecuteSqlCommand(Query);
                        }
                        else
                        {
                            queryExec = ctx.Database.ExecuteSqlCommand(Query, Param);
                        }

                        db.Commit();
                        return queryExec;
                    }
                    catch (Exception ex)
                    {
                        db.Rollback();
                        return 0;
                    }
                }
            }
        }

        // return single<Model>
        public static T SqlQuerySingle<T>(string Query, object[] Param = null) where T : class, new()
        {
            using (var ctx = new indomodaEntities())
            {
                T queryExec = null;
                using (var db = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        if (Param == null)
                        {
                            queryExec = ctx.Database.SqlQuery<T>(Query).SingleOrDefault();
                        }
                        else
                        {
                            queryExec = ctx.Database.SqlQuery<T>(Query, Param).SingleOrDefault();
                        }

                        db.Commit();
                        return queryExec;
                    }
                    catch (Exception ex)
                    {
                        db.Rollback();
                        return null;
                    }
                }
            }
        }

        // return list<Model>
        public static List<T> SqlQuery<T>(string Query, object[] Param = null) where T : class
        {
            using (var ctx = new indomodaEntities())
            {
                List<T> queryExec = null;
                using (var db = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        if (Param == null)
                        {
                            queryExec = ctx.Database.SqlQuery<T>(Query).ToList();
                        }
                        else
                        {
                            queryExec = ctx.Database.SqlQuery<T>(Query, Param).ToList();
                        }

                        db.Commit();
                        return queryExec;
                    }
                    catch (Exception ex)
                    {
                        db.Rollback();
                        return null;
                    }
                }
            }
        }
    }
}
