using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcaApiWebJob
{
    public static class SQL
    {
        public static string CreateFKSQL
        {
            get
            {
                return @"ALTER TABLE [dbo].[Competitions]  WITH CHECK ADD  CONSTRAINT [FK_Competitions_Countries] FOREIGN KEY([countryId])
REFERENCES[dbo].[Countries]([id])

ALTER TABLE[dbo].[Competitions] CHECK CONSTRAINT[FK_Competitions_Countries]

            ALTER TABLE[dbo].[Countries]  WITH CHECK ADD CONSTRAINT[FK_Countries_Continents] FOREIGN KEY([continentId])
REFERENCES[dbo].[Continents] ([id])

ALTER TABLE[dbo].[Countries] CHECK CONSTRAINT[FK_Countries_Continents]

            ALTER TABLE[dbo].[Persons]  WITH CHECK ADD CONSTRAINT[FK_Persons_Countries] FOREIGN KEY([countryId])
REFERENCES[dbo].[Countries] ([id])

ALTER TABLE[dbo].[Persons] CHECK CONSTRAINT[FK_Persons_Countries]

            ALTER TABLE[dbo].[Scrambles]  WITH CHECK ADD CONSTRAINT[FK_Scrambles_Competitions] FOREIGN KEY([competitionId])
REFERENCES[dbo].[Competitions] ([id])

ALTER TABLE[dbo].[Scrambles] CHECK CONSTRAINT[FK_Scrambles_Competitions]

            ALTER TABLE[dbo].[Scrambles]  WITH CHECK ADD CONSTRAINT[FK_Scrambles_Events] FOREIGN KEY([eventId])
REFERENCES[dbo].[Events] ([id])

ALTER TABLE[dbo].[Scrambles] CHECK CONSTRAINT[FK_Scrambles_Events]

            ALTER TABLE[dbo].[Scrambles]  WITH CHECK ADD CONSTRAINT[FK_Scrambles_Rounds] FOREIGN KEY([roundId])
REFERENCES[dbo].[Rounds] ([id])

ALTER TABLE[dbo].[Scrambles] CHECK CONSTRAINT[FK_Scrambles_Rounds]";
            }
        }

        public static string DropFKSQL
        {
            get
            {
                return @"ALTER TABLE [dbo].[Competitions] DROP  CONSTRAINT [FK_Competitions_Countries]
            ALTER TABLE[dbo].[Countries] DROP CONSTRAINT[FK_Countries_Continents]
            ALTER TABLE[dbo].[Persons] DROP CONSTRAINT[FK_Persons_Countries]
            ALTER TABLE[dbo].[Scrambles] DROP CONSTRAINT[FK_Scrambles_Competitions]
            ALTER TABLE[dbo].[Scrambles] DROP CONSTRAINT[FK_Scrambles_Events]
            ALTER TABLE[dbo].[Scrambles] DROP CONSTRAINT[FK_Scrambles_Rounds]";
            }
        }

    }
}
