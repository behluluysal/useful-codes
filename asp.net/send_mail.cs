MailMessage mm = new MailMessage("mail", "mailtosend");
                            mm.Subject = "Aktivasyon Kodunuz";
                            mm.IsBodyHtml = false;
                            mm.Body = aktivasyonkodu;
                            using (SmtpClient smtp = new SmtpClient())
                            {
                                smtp.Host = "smtp.gmail.com";
                                smtp.EnableSsl = true;
                                NetworkCredential NetworkCred = new NetworkCredential("mail", "password");
                                smtp.UseDefaultCredentials = true;
                                smtp.Credentials = NetworkCred;
                                smtp.Port = 587;
                                smtp.Send(mm);
                                ViewBag.Message = "Email sent.";
                            }