﻿using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon;
using Amazon.S3;
using System.IO;
using NUnit.Framework;
using CommonTests.Framework;
using Amazon.SecurityToken;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class CredentialsTests
    {
        [Test]
        [Category("Credentials")]
        public void TestSessionCredentials()
        {
            using (var sts = TestBase.CreateClient<AmazonSecurityTokenServiceClient>())
            {
                AWSCredentials credentials = sts.GetSessionTokenAsync().Result.Credentials;

                var originalS3Signature = AWSConfigsS3.UseSignatureVersion4;
                AWSConfigsS3.UseSignatureVersion4 = true;
                try
                {

                    using (var ec2 = TestBase.CreateClient < Amazon.EC2.AmazonEC2Client>(credentials))
                    {
                        var regions = ec2.DescribeRegionsAsync().Result.Regions;
                        Console.WriteLine(regions.Count);
                    }

                    using (var s3 = TestBase.CreateClient < Amazon.S3.AmazonS3Client>(credentials))
                    {
                        var buckets = s3.ListBucketsAsync().Result.Buckets;
                        Console.WriteLine(buckets.Count);
                    }

                    using (var swf = TestBase.CreateClient < Amazon.SimpleWorkflow.AmazonSimpleWorkflowClient>(credentials))
                    {
                        var domains = swf.ListDomainsAsync(new Amazon.SimpleWorkflow.Model.ListDomainsRequest { RegistrationStatus = "REGISTERED" }).Result.DomainInfos;
                        Console.WriteLine(domains.Infos.Count);
                    }

                    using (var swf = TestBase.CreateClient < Amazon.SimpleWorkflow.AmazonSimpleWorkflowClient>(credentials))
                    {
                        var domains = swf.ListDomainsAsync(new Amazon.SimpleWorkflow.Model.ListDomainsRequest { RegistrationStatus = "REGISTERED" }).Result.DomainInfos;
                        Console.WriteLine(domains.Infos.Count);
                    }
                }
                finally
                {
                    AWSConfigsS3.UseSignatureVersion4 = originalS3Signature;
                }
            }
        }

//        [Test]
//        public void TestCredentialsFile()
//        {
//            var ic = new ImmutableCredentials("access-key", "secret-key", null);
//            TestCredentialsFile(ic);
//            ic = new ImmutableCredentials("access-key", "secret-key", "token");
//            TestCredentialsFile(ic);
//        }

//        private static void TestCredentialsFile(ImmutableCredentials ic)
//        {
//            var profileName = "testProfile";
//            var profilesLocation = WriteCreds(profileName, ic);
//            var creds = new StoredProfileAWSCredentials(profileName, profilesLocation);
//            var rc = creds.GetCredentials();
//            Assert.AreEqual(ic.SecretKey, rc.SecretKey);
//            Assert.AreEqual(ic.AccessKey, rc.AccessKey);
//            Assert.AreEqual(ic.UseToken, rc.UseToken);
//            Assert.AreEqual(ic.Token, rc.Token);

//            for (int i = 0; i < 4; i++)
//            {
//                creds = new StoredProfileAWSCredentials(profileName + i, profilesLocation);
//                Assert.IsNotNull(creds);
//                rc = creds.GetCredentials();
//                Assert.IsNotNull(rc.AccessKey);
//                Assert.IsNotNull(rc.SecretKey);
//                var shouldHaveToken = (i % 2 == 1);
//                Assert.AreEqual(shouldHaveToken, rc.UseToken);
//            }
//        }

//        private static ImmutableCredentials basicCreds = new ImmutableCredentials("ac0", "sc1", null);
//        private static ImmutableCredentials sessionCreds = new ImmutableCredentials("ac2", "sc3", "token");
//        private static string WriteCreds(string profileName, ImmutableCredentials ic)
//        {
//            string configPath = Path.GetFullPath("credentials");
//            using (var stream = File.Open(configPath, FileMode.Create, FileAccess.Write, FileShare.None))
//            using (var writer = new StreamWriter(stream))
//            {
//                AppendCredentialsSet(writer, profileName + "0", basicCreds);
//                AppendCredentialsSet(writer, profileName + "1", sessionCreds);
//                AppendCredentialsSet(writer, profileName, ic);
//                AppendCredentialsSet(writer, profileName + "2", basicCreds);
//                AppendCredentialsSet(writer, profileName + "3", sessionCreds);
//            }

//            return configPath;
//        }

//        private static void AppendCredentialsSet(StreamWriter writer, string profileName, ImmutableCredentials ic)
//        {
//            /*
//[aws-dr-tools-test-profile]
//aws_access_key_id = ACCESS_KEY_0
//aws_secret_access_key = SECRET_KEY_0
//aws_session_token = TOKEN_0
//             */
//            writer.WriteLine();
//            writer.WriteLine("; profile {0} and its credentials", profileName);
//            writer.WriteLine("# alternative comment marker");
//            writer.WriteLine("[{0}]", profileName);
//            writer.WriteLine("aws_access_key_id = {0}", ic.AccessKey);
//            writer.WriteLine("aws_secret_access_key = {0}", ic.SecretKey);
//            if (ic.UseToken)
//                writer.WriteLine("aws_session_token = {0}", ic.Token);
//            writer.WriteLine();
//        }
    }
}