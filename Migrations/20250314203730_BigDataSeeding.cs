﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlashCardLearning.Migrations
{
    /// <inheritdoc />
    public partial class BigDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a8e5d29a-6d67-4c76-8cc7-c444f3e6f5b8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e363572b-b54b-433d-a001-2e1252c81852"));

            migrationBuilder.InsertData(
                table: "FlashCard",
                columns: new[] { "Id", "Description", "Name", "type" },
                values: new object[,]
                {
                    { new Guid("004ad516-4f5e-4db8-93d9-2e6847e0ae49"), "a card", "card 1", "Text" },
                    { new Guid("0079423b-8858-4fe4-be99-349cee88783b"), "a card", "card 1", "Text" },
                    { new Guid("00d37f0e-0841-4eea-9d4e-b710793c651c"), "a card", "card 1", "Text" },
                    { new Guid("01675a28-e993-4d99-8175-ef013c5cdb7a"), "a card", "card 1", "Text" },
                    { new Guid("01876b0b-d3a8-4b95-8afb-8896a2bd8e39"), "a card", "card 1", "Text" },
                    { new Guid("0194b09a-8616-48b7-8618-f250b29cfe12"), "a card", "card 1", "Text" },
                    { new Guid("01c57a1f-8988-4806-a167-a7c38fde80ea"), "a card", "card 1", "Text" },
                    { new Guid("01c6f0d6-c6e2-4d86-a599-a59aaf4c5359"), "a card", "card 1", "Text" },
                    { new Guid("020b1d4a-1947-44a2-a448-8145dd194d2e"), "a card", "card 1", "Text" },
                    { new Guid("02501554-9916-4482-95ef-b291e34a8473"), "a card", "card 1", "Text" },
                    { new Guid("0279dfc7-b8a4-4406-a1a2-f1a652e47385"), "a card", "card 1", "Text" },
                    { new Guid("02b890ad-d7e4-4b3f-a55a-2db288da02ea"), "a card", "card 1", "Text" },
                    { new Guid("02c0c352-4095-4366-8740-41a030ee178d"), "a card", "card 1", "Text" },
                    { new Guid("02c72e9f-83ee-4c91-9ff6-b9806edb6f77"), "a card", "card 1", "Text" },
                    { new Guid("03198661-1fad-4f90-858f-1200218fe228"), "a card", "card 1", "Text" },
                    { new Guid("035cb57e-a91e-472c-8661-25a5c9521927"), "a card", "card 1", "Text" },
                    { new Guid("03692c42-8da4-4826-b882-58611be291d2"), "a card", "card 1", "Text" },
                    { new Guid("036c8c4c-8462-400c-8544-6774875baea2"), "a card", "card 1", "Text" },
                    { new Guid("0392dafc-a90e-45bd-9873-2770acdfc79c"), "a card", "card 1", "Text" },
                    { new Guid("03cb69ca-9c8a-42b3-bfd6-78d33ce9acbd"), "a card", "card 1", "Text" },
                    { new Guid("03df1434-4e16-4dc7-bcb1-8219b27fa845"), "a card", "card 1", "Text" },
                    { new Guid("046f86f4-51b9-4c47-96c2-592f1f34c35f"), "a card", "card 1", "Text" },
                    { new Guid("047cd526-d1b6-4e2b-a346-f14c5e44e3de"), "a card", "card 1", "Text" },
                    { new Guid("04825d22-82fd-4b3c-a04e-08017e733d7f"), "a card", "card 1", "Text" },
                    { new Guid("04913335-1c97-4f97-9cea-8c60cc45b160"), "a card", "card 1", "Text" },
                    { new Guid("04b978e4-6c00-4e0e-b893-bdabe7d29fcc"), "a card", "card 1", "Text" },
                    { new Guid("04d4b2cc-50a5-4e07-bf3a-d88363ac8e9d"), "a card", "card 1", "Text" },
                    { new Guid("04fc507b-1d0c-4270-b1a3-01986685c3cc"), "a card", "card 1", "Text" },
                    { new Guid("062da6a9-e4de-4f6e-9133-3e3b01f11195"), "a card", "card 1", "Text" },
                    { new Guid("06388984-c9a7-4e66-b8df-590aefeebeaa"), "a card", "card 1", "Text" },
                    { new Guid("068bee53-9846-4c19-a6e5-c5c267e55e73"), "a card", "card 1", "Text" },
                    { new Guid("06dd708c-0640-44da-9eb7-a83b35aa3bc1"), "a card", "card 1", "Text" },
                    { new Guid("0795a864-0e22-45e9-9824-c2e056163694"), "a card", "card 1", "Text" },
                    { new Guid("07c9597d-733d-4c1f-8c55-67cc8f10034b"), "a card", "card 1", "Text" },
                    { new Guid("07d0b6b8-0eaf-4081-928f-87803f01ca05"), "a card", "card 1", "Text" },
                    { new Guid("07d1ee41-df94-4852-b287-395d59df57ae"), "a card", "card 1", "Text" },
                    { new Guid("07fad4a5-9ce7-4e75-be0d-a541bc85d69f"), "a card", "card 1", "Text" },
                    { new Guid("081b2e3a-2ec7-43c2-b48f-f5c9923068b3"), "a card", "card 1", "Text" },
                    { new Guid("08454d16-ea94-4665-a6eb-e9b6b2f88d50"), "a card", "card 1", "Text" },
                    { new Guid("08603a5e-04cc-4f6d-a89e-dd3e6fa5b42c"), "a card", "card 1", "Text" },
                    { new Guid("094b51a3-83ae-4b8f-b279-4095a606f423"), "a card", "card 1", "Text" },
                    { new Guid("097ac624-9151-4c5e-a3c6-fd511a52b137"), "a card", "card 1", "Text" },
                    { new Guid("0a1179a5-91b1-4b37-a35b-80e60f726efd"), "a card", "card 1", "Text" },
                    { new Guid("0a8e96f0-1dd7-4118-9482-3e375c088113"), "a card", "card 1", "Text" },
                    { new Guid("0aa31bc2-f345-4a87-ad6b-a675dddbf81b"), "a card", "card 1", "Text" },
                    { new Guid("0b444900-5bbd-473d-ae8f-3a080f79ffb0"), "a card", "card 1", "Text" },
                    { new Guid("0ba09003-d726-44ac-8ff6-068d615fe648"), "a card", "card 1", "Text" },
                    { new Guid("0ba0b1a2-f0e4-46c7-b06d-108c2980085a"), "a card", "card 1", "Text" },
                    { new Guid("0bd9891c-74e7-4cc8-a3e4-4ac19eff3153"), "a card", "card 1", "Text" },
                    { new Guid("0c019b7a-76ae-43ef-b546-6a51e2ec8ad8"), "a card", "card 1", "Text" },
                    { new Guid("0c1e49c4-a8c9-4692-af0d-60784121c03c"), "a card", "card 1", "Text" },
                    { new Guid("0c684ee4-5f34-4b43-bede-10ff8aea2be7"), "a card", "card 1", "Text" },
                    { new Guid("0cd8b3e5-a3ad-414c-960b-d96e56cf7f70"), "a card", "card 1", "Text" },
                    { new Guid("0cda6a89-1d19-47b4-9bb5-1587384c4741"), "a card", "card 1", "Text" },
                    { new Guid("0d02ee21-d23a-4fff-ae18-e61710a8d936"), "a card", "card 1", "Text" },
                    { new Guid("0d3f5bca-19c4-4c50-a2c7-fe6a47bfd82c"), "a card", "card 1", "Text" },
                    { new Guid("0dcdb15b-dd7c-4b29-9071-d89925b91d3b"), "a card", "card 1", "Text" },
                    { new Guid("0e1d69fa-07f8-4a28-80f6-59743f923621"), "a card", "card 1", "Text" },
                    { new Guid("0ee4ede0-9871-42be-9e33-335c8f145edb"), "a card", "card 1", "Text" },
                    { new Guid("0ee9e86a-1eac-41c5-b167-947b2906014d"), "a card", "card 1", "Text" },
                    { new Guid("0f09255c-d04d-4f41-aef3-1b844bd9b311"), "a card", "card 1", "Text" },
                    { new Guid("0f23299c-b8b3-4d01-9050-6c9fc10779f6"), "a card", "card 1", "Text" },
                    { new Guid("0f3dddf8-89d5-45f5-a2c8-37a86aa5fce3"), "a card", "card 1", "Text" },
                    { new Guid("0fea0d39-560a-4e9b-a96a-af7d541937fe"), "a card", "card 1", "Text" },
                    { new Guid("0ff17f5d-2597-4f56-8b44-4f7d09eef03e"), "a card", "card 1", "Text" },
                    { new Guid("10026a51-b141-4d82-a6a0-681f27812cd9"), "a card", "card 1", "Text" },
                    { new Guid("10075b84-ab0c-4530-8982-e596a8802601"), "a card", "card 1", "Text" },
                    { new Guid("102a7e36-b599-4960-b102-d7cde2688aac"), "a card", "card 1", "Text" },
                    { new Guid("10ecca34-b54e-497c-aacd-78d04870e5d6"), "a card", "card 1", "Text" },
                    { new Guid("10fc79f4-7368-4b9c-b9ac-5ad12381c489"), "a card", "card 1", "Text" },
                    { new Guid("1173a0bd-45bc-4140-b46b-f93b7d190bd9"), "a card", "card 1", "Text" },
                    { new Guid("117464c0-8f45-4853-9e22-e3d61bd99ae2"), "a card", "card 1", "Text" },
                    { new Guid("11bd8205-cfcf-4409-b065-c4f073915dd6"), "a card", "card 1", "Text" },
                    { new Guid("11fb06c8-9913-49b2-b134-4d2677fb84e9"), "a card", "card 1", "Text" },
                    { new Guid("121dde4a-c207-4fa8-ae3f-a0f668a058b1"), "a card", "card 1", "Text" },
                    { new Guid("1246224e-e090-4076-82e2-be4d2483a776"), "a card", "card 1", "Text" },
                    { new Guid("12ca5c6a-432e-4b2d-955e-376e2c30fe4d"), "a card", "card 1", "Text" },
                    { new Guid("1303aa48-172e-4df6-aa1e-abebe58a5929"), "a card", "card 1", "Text" },
                    { new Guid("13d81e01-bfd6-49a1-ae8a-1b84baf09ff3"), "a card", "card 1", "Text" },
                    { new Guid("14791848-4b22-46d8-8263-b2cca8610754"), "a card", "card 1", "Text" },
                    { new Guid("149afa6c-2464-4208-8c08-ba5332217fa8"), "a card", "card 1", "Text" },
                    { new Guid("14a65b6d-2bb5-49fa-a2bc-a097bb26939e"), "a card", "card 1", "Text" },
                    { new Guid("15184afb-3169-46a8-90fa-c53590cfd15b"), "a card", "card 1", "Text" },
                    { new Guid("15266539-bce3-4841-9563-33f584fa85dd"), "a card", "card 1", "Text" },
                    { new Guid("155ee89d-2837-48e5-9c9b-0d4554f69f46"), "a card", "card 1", "Text" },
                    { new Guid("15770b8d-fec3-4ce0-bbfb-2027e4a20824"), "a card", "card 1", "Text" },
                    { new Guid("158fad7a-33c1-4f40-94d4-1478c3586003"), "a card", "card 1", "Text" },
                    { new Guid("160195ad-8130-4e2e-8bbc-8e83ec74632b"), "a card", "card 1", "Text" },
                    { new Guid("161cfa35-656d-4bfd-82f8-375b29972853"), "a card", "card 1", "Text" },
                    { new Guid("162b43f6-1a00-4ea4-b8ef-6951e7baad2f"), "a card", "card 1", "Text" },
                    { new Guid("1694b525-c377-4342-8bce-bd918bdea2b5"), "a card", "card 1", "Text" },
                    { new Guid("16b023e9-1366-4ee1-913f-0f588a86568c"), "a card", "card 1", "Text" },
                    { new Guid("16e54429-ccad-4483-a6f7-54c6d3ce2baa"), "a card", "card 1", "Text" },
                    { new Guid("176e5af7-5de2-4412-887d-ce14202bb686"), "a card", "card 1", "Text" },
                    { new Guid("1772bb16-75da-4936-9446-8485e2432fad"), "a card", "card 1", "Text" },
                    { new Guid("17a27437-e65c-459d-8845-d3e6659b0f95"), "a card", "card 1", "Text" },
                    { new Guid("17bc3eab-7c12-4156-b6eb-a12daa6fec57"), "a card", "card 1", "Text" },
                    { new Guid("18114e6a-4778-45c5-8cf9-f294f3f709d7"), "a card", "card 1", "Text" },
                    { new Guid("1827f7b1-fc69-42ed-ac15-b375f7e1a039"), "a card", "card 1", "Text" },
                    { new Guid("183889aa-750e-483a-a79a-1b076d012481"), "a card", "card 1", "Text" },
                    { new Guid("18d2c0f8-574f-41dd-8e22-d852c1d2daa6"), "a card", "card 1", "Text" },
                    { new Guid("18d577af-e54b-4154-90e0-90ed3bb986d1"), "a card", "card 1", "Text" },
                    { new Guid("190c48a4-1f5d-4670-9932-1a4188726559"), "a card", "card 1", "Text" },
                    { new Guid("190c7283-c6d3-40dc-a150-35614ba88202"), "a card", "card 1", "Text" },
                    { new Guid("19914501-de9f-4103-bab5-7ef87ee019ec"), "a card", "card 1", "Text" },
                    { new Guid("19993a42-3869-4633-8a05-69c22db7aa77"), "a card", "card 1", "Text" },
                    { new Guid("19e3bc31-fffe-4bd0-89f3-2f051b4b3d7a"), "a card", "card 1", "Text" },
                    { new Guid("19eab34d-da23-4bc9-8ff2-f42fe7ea1db2"), "a card", "card 1", "Text" },
                    { new Guid("1a228ff9-3e17-4ac7-87b4-d45293374682"), "a card", "card 1", "Text" },
                    { new Guid("1a4a2ece-cf37-449b-bb3c-21130d7720db"), "a card", "card 1", "Text" },
                    { new Guid("1a7eaa3b-a06f-4939-baa3-84646a5d1f0a"), "a card", "card 1", "Text" },
                    { new Guid("1bdff7dc-d0aa-4aba-808a-2f2b876f81a1"), "a card", "card 1", "Text" },
                    { new Guid("1bf30209-368a-41e3-b5f1-605fd1172cb3"), "a card", "card 1", "Text" },
                    { new Guid("1c3208ae-9735-44fe-9824-3e378ce787be"), "a card", "card 1", "Text" },
                    { new Guid("1c3903f3-4915-4062-8c58-5afc47e1f270"), "a card", "card 1", "Text" },
                    { new Guid("1c396ddf-d083-4dfb-8739-0766670db582"), "a card", "card 1", "Text" },
                    { new Guid("1ca260d1-b792-4a73-bc8f-8a4c83d5656b"), "a card", "card 1", "Text" },
                    { new Guid("1cb499b3-6435-4f20-bc58-c9408c63dea3"), "a card", "card 1", "Text" },
                    { new Guid("1cf450f0-9ffb-4ebf-b497-94dfef4bd3cd"), "a card", "card 1", "Text" },
                    { new Guid("1d4315a8-3a56-41f9-b52b-79f5b09d5d08"), "a card", "card 1", "Text" },
                    { new Guid("1d44a558-3621-477a-9426-b9f11453937a"), "a card", "card 1", "Text" },
                    { new Guid("1da55a00-2098-4e5b-8e48-575c5b22aa1c"), "a card", "card 1", "Text" },
                    { new Guid("1dcbb29c-6fd2-4843-927e-d582524eec4a"), "a card", "card 1", "Text" },
                    { new Guid("1e50b8ea-a2c8-4322-b86d-0112e029666a"), "a card", "card 1", "Text" },
                    { new Guid("1e66fec2-d0de-4d91-b79b-3829ce70af08"), "a card", "card 1", "Text" },
                    { new Guid("1e8770a1-efae-4ec1-85f4-27d1e8d50a58"), "a card", "card 1", "Text" },
                    { new Guid("1eae6e87-bd51-4b7a-b09d-fc9c86f6ad6a"), "a card", "card 1", "Text" },
                    { new Guid("1ec92ba2-c1b4-4403-b07a-d20f7395b4db"), "a card", "card 1", "Text" },
                    { new Guid("1ed4f506-6101-40b3-b80e-6a0c13ee580e"), "a card", "card 1", "Text" },
                    { new Guid("1f00e22b-694b-4a0d-8e3c-8644ebc9ef99"), "a card", "card 1", "Text" },
                    { new Guid("1f47100b-3b5b-4f7f-bec6-eaa30b5880b0"), "a card", "card 1", "Text" },
                    { new Guid("1fb5541f-684c-4806-bcd9-3a8b1f86e38c"), "a card", "card 1", "Text" },
                    { new Guid("204ff690-6278-43b0-aad5-eb702e2fd870"), "a card", "card 1", "Text" },
                    { new Guid("20849939-0c44-4a23-92e8-e7ce5417896d"), "a card", "card 1", "Text" },
                    { new Guid("20a0d452-01ce-456a-a311-f3e28674e8ed"), "a card", "card 1", "Text" },
                    { new Guid("20d41623-a4d7-4449-9fcd-b013ab1e8eca"), "a card", "card 1", "Text" },
                    { new Guid("20e3ef1d-7fee-414d-8e48-9861002604af"), "a card", "card 1", "Text" },
                    { new Guid("21405bc0-6d45-44af-b13b-e92fdc56ad87"), "a card", "card 1", "Text" },
                    { new Guid("2169f33a-7c41-45c5-a59e-7c6f2dc2740b"), "a card", "card 1", "Text" },
                    { new Guid("2185acb6-9fa8-4093-a471-b643711ae295"), "a card", "card 1", "Text" },
                    { new Guid("218d3ca2-7034-47c3-a5a6-9f5b5933eee9"), "a card", "card 1", "Text" },
                    { new Guid("21937e9e-a548-4ca7-9bea-e56601d7d20b"), "a card", "card 1", "Text" },
                    { new Guid("221c9314-3b10-4c7b-b0a3-c1d9be7d44e4"), "a card", "card 1", "Text" },
                    { new Guid("2297bc62-7f78-4d0a-b211-dfc3ba331551"), "a card", "card 1", "Text" },
                    { new Guid("22afb229-091d-4bcf-8157-5ce2766ec359"), "a card", "card 1", "Text" },
                    { new Guid("22d7bf80-b86a-4651-b2e5-c0c7edc6a496"), "a card", "card 1", "Text" },
                    { new Guid("234ddbef-01db-409c-aec6-87d75df395d4"), "a card", "card 1", "Text" },
                    { new Guid("238a4371-1696-47ca-ae55-a32941cac044"), "a card", "card 1", "Text" },
                    { new Guid("23983ad4-d207-45aa-8df8-feaf11e0e6a1"), "a card", "card 1", "Text" },
                    { new Guid("23a655e3-faa4-42f0-8112-340fa9fc1add"), "a card", "card 1", "Text" },
                    { new Guid("23ac6aa8-4ef3-4881-b4b2-52094c03c88f"), "a card", "card 1", "Text" },
                    { new Guid("23b87e3e-4cb3-4570-9913-e8dccdf767c4"), "a card", "card 1", "Text" },
                    { new Guid("241db16f-f928-4315-a3f0-49db3ac8a4af"), "a card", "card 1", "Text" },
                    { new Guid("245554c2-4dd3-43e7-a389-8adedc42562a"), "a card", "card 1", "Text" },
                    { new Guid("24948e74-dfa0-483e-8ae3-591559a7b00d"), "a card", "card 1", "Text" },
                    { new Guid("251f0e74-0691-4f15-b4a8-8b929c532b8b"), "a card", "card 1", "Text" },
                    { new Guid("259fd064-5ed1-4bf2-8a12-c466b3bb1858"), "a card", "card 1", "Text" },
                    { new Guid("25fe672f-c23b-4fbb-bf40-c7993f1bf4cf"), "a card", "card 1", "Text" },
                    { new Guid("262d297f-aca1-42f5-bef0-128ce3204589"), "a card", "card 1", "Text" },
                    { new Guid("263f1410-52da-4096-bcdd-b500060c6f26"), "a card", "card 1", "Text" },
                    { new Guid("2640e795-aa46-4403-86ea-4d2e98966143"), "a card", "card 1", "Text" },
                    { new Guid("2732d814-edac-4e1e-ad05-a32dab1fae39"), "a card", "card 1", "Text" },
                    { new Guid("273e6c5b-ca7f-4315-83a2-9fa9c9085e08"), "a card", "card 1", "Text" },
                    { new Guid("2762513c-3219-441a-9f57-be21d76faf57"), "a card", "card 1", "Text" },
                    { new Guid("27797916-b891-450a-b207-eecac0c24c65"), "a card", "card 1", "Text" },
                    { new Guid("27941be6-34ad-4500-aaab-a6e971d7fe08"), "a card", "card 1", "Text" },
                    { new Guid("27df3d63-2f0d-4c3b-8e7b-68a67e405024"), "a card", "card 1", "Text" },
                    { new Guid("28aaa9ca-eef3-4ae4-8869-69636c54a293"), "a card", "card 1", "Text" },
                    { new Guid("28cbae45-aaac-45a8-98a8-884a98d02c9a"), "a card", "card 1", "Text" },
                    { new Guid("299fce64-82fb-4a36-a00c-0385cb019ff4"), "a card", "card 1", "Text" },
                    { new Guid("29bdc81d-4b60-4fb0-802c-06afdc08015a"), "a card", "card 1", "Text" },
                    { new Guid("2a31b362-f406-4c91-b443-c488f12dc5cf"), "a card", "card 1", "Text" },
                    { new Guid("2a9b1bd9-d0d4-49d0-b8a6-ada3e77b0de8"), "a card", "card 1", "Text" },
                    { new Guid("2ad48329-b802-491d-bbaf-b0c3dc0107f3"), "a card", "card 1", "Text" },
                    { new Guid("2ae39b83-f21d-4af7-9587-7456e39cec44"), "a card", "card 1", "Text" },
                    { new Guid("2b0b2b0c-0837-433f-8206-e2995112074f"), "a card", "card 1", "Text" },
                    { new Guid("2b5e8ef6-9c70-4fba-82cc-026d264ebe13"), "a card", "card 1", "Text" },
                    { new Guid("2bb43e55-b362-4d82-a0d7-458427451007"), "a card", "card 1", "Text" },
                    { new Guid("2bb7e93e-b1e4-4c6c-a76e-1200dfdd75d6"), "a card", "card 1", "Text" },
                    { new Guid("2c45c303-8420-4f48-90ed-5685a69b419b"), "a card", "card 1", "Text" },
                    { new Guid("2c75282f-89d6-492d-ac41-c86ae6ec7f59"), "a card", "card 1", "Text" },
                    { new Guid("2cace7bf-d772-4309-bf8a-c50dd357d7d5"), "a card", "card 1", "Text" },
                    { new Guid("2d1f47ff-41a4-4ae7-ba10-b08cae07cdaf"), "a card", "card 1", "Text" },
                    { new Guid("2d4cae15-744b-4541-bed9-91478b7ce296"), "a card", "card 1", "Text" },
                    { new Guid("2d80bfc4-3bc7-4e16-aaf5-a6536f954197"), "a card", "card 1", "Text" },
                    { new Guid("2da131fd-4ca4-4903-b12f-b7acc18d51ca"), "a card", "card 1", "Text" },
                    { new Guid("2e34280c-c8b3-4177-8dc5-ee0013bfcf15"), "a card", "card 1", "Text" },
                    { new Guid("2eda07f1-9a07-4047-875e-10a256dae0c6"), "a card", "card 1", "Text" },
                    { new Guid("2f91cb04-4c4c-4575-9bb9-8029da2b1e49"), "a card", "card 1", "Text" },
                    { new Guid("2fc0a22c-d50e-4284-8fb5-dbbdcc42d2e8"), "a card", "card 1", "Text" },
                    { new Guid("2ffcf48c-b035-49c5-b8d6-b203950d0afb"), "a card", "card 1", "Text" },
                    { new Guid("3034c93c-19e0-4515-b710-e2b2cb733af2"), "a card", "card 1", "Text" },
                    { new Guid("3043a5c4-0118-42e6-b301-0656814af312"), "a card", "card 1", "Text" },
                    { new Guid("306061f0-7005-4dca-a426-7d38cde5af32"), "a card", "card 1", "Text" },
                    { new Guid("3101d28e-9002-402f-a1f5-4c2f03784c1f"), "a card", "card 1", "Text" },
                    { new Guid("31274403-db48-4c6b-b1fa-4f8e7d49222d"), "a card", "card 1", "Text" },
                    { new Guid("314d22ca-622d-4af4-bf3a-a8b05cd785af"), "a card", "card 1", "Text" },
                    { new Guid("316a5261-2dfc-4638-b811-8dd7ed29df89"), "a card", "card 1", "Text" },
                    { new Guid("31d6c8bc-abde-4ea5-9731-21bad561e811"), "a card", "card 1", "Text" },
                    { new Guid("3218e3e1-30e9-4cb0-8c3e-b3af6c99237b"), "a card", "card 1", "Text" },
                    { new Guid("3226fc10-e965-41df-9ddf-8bb5940f6994"), "a card", "card 1", "Text" },
                    { new Guid("3245e6af-6b9a-4fd5-8fee-79e4e3c23a6f"), "a card", "card 1", "Text" },
                    { new Guid("324e065d-4baf-450f-ba05-27024713fe46"), "a card", "card 1", "Text" },
                    { new Guid("3263db17-df7d-477e-9e3e-3dca179ae2df"), "a card", "card 1", "Text" },
                    { new Guid("327b7a89-a1d9-45aa-b557-f72036a1c3cf"), "a card", "card 1", "Text" },
                    { new Guid("32a53a42-2a8a-44cf-bc8b-f1bcbc4b10bb"), "a card", "card 1", "Text" },
                    { new Guid("331e199d-b364-40f1-a1b9-c862c146626a"), "a card", "card 1", "Text" },
                    { new Guid("336a4341-e15f-4005-be0e-9982d147ace6"), "a card", "card 1", "Text" },
                    { new Guid("3371b987-85d5-474a-8af3-5b76f2613e25"), "a card", "card 1", "Text" },
                    { new Guid("337f2be9-93f3-4585-b773-2bd45f075c20"), "a card", "card 1", "Text" },
                    { new Guid("33b4d1b0-00b0-49cb-b9d9-641d4d85f77f"), "a card", "card 1", "Text" },
                    { new Guid("33ba9084-508a-4790-84a1-c908eff59605"), "a card", "card 1", "Text" },
                    { new Guid("3496e326-4ddd-42ec-b56d-4ba39707f945"), "a card", "card 1", "Text" },
                    { new Guid("34f45ff9-de29-4e54-915e-44e9d7e020dc"), "a card", "card 1", "Text" },
                    { new Guid("35042847-7b35-483e-93ff-a174f9b0232a"), "a card", "card 1", "Text" },
                    { new Guid("367f0988-29d0-431d-8332-b8306d4eaccb"), "a card", "card 1", "Text" },
                    { new Guid("36af8b20-d4a5-495f-806e-2892d2ef0357"), "a card", "card 1", "Text" },
                    { new Guid("36f3cc7a-89ef-4ee8-8a1c-f758d99ca8d9"), "a card", "card 1", "Text" },
                    { new Guid("36f7bcf4-9d05-4a23-b843-0e38cd2feb52"), "a card", "card 1", "Text" },
                    { new Guid("370e5b27-4f7a-49a1-87ee-bc9e8f89285b"), "a card", "card 1", "Text" },
                    { new Guid("3723ef9e-0936-4e0f-9746-a8b321d75e9d"), "a card", "card 1", "Text" },
                    { new Guid("372c07ec-2f99-428a-b4ab-aa5726b10627"), "a card", "card 1", "Text" },
                    { new Guid("3770c603-4054-48c3-a461-97f050c227eb"), "a card", "card 1", "Text" },
                    { new Guid("37ec7fdb-e4be-4ade-93c6-6c1dc7b24c67"), "a card", "card 1", "Text" },
                    { new Guid("381b4f34-1491-4192-b6b2-a93607a37d89"), "a card", "card 1", "Text" },
                    { new Guid("382273fa-c4b5-4758-a7d3-c0f8fbafff76"), "a card", "card 1", "Text" },
                    { new Guid("386250d2-88f5-424e-aa37-2d76f4ab7d3f"), "a card", "card 1", "Text" },
                    { new Guid("3890f13e-f361-4ab0-a84c-61af4c6ac45b"), "a card", "card 1", "Text" },
                    { new Guid("38cf11ca-13e2-4b82-97a3-1b94b4fa68c9"), "a card", "card 1", "Text" },
                    { new Guid("38e6215c-51fc-46d4-869b-c3deb2a5b73e"), "a card", "card 1", "Text" },
                    { new Guid("39fed475-c69b-495c-b3f2-bdbcc71be21f"), "a card", "card 1", "Text" },
                    { new Guid("3a7685dd-1e65-43b9-9cc0-0900662be6c0"), "a card", "card 1", "Text" },
                    { new Guid("3b0ab149-f076-4790-81c5-4918e46a09cb"), "a card", "card 1", "Text" },
                    { new Guid("3b3e3e00-7d7a-425a-a6e7-3b67c7c7c3c7"), "a card", "card 1", "Text" },
                    { new Guid("3b716de0-7924-4762-a266-aa0821549543"), "a card", "card 1", "Text" },
                    { new Guid("3b7d7d0c-0e63-40ff-b64a-c2a83c98221b"), "a card", "card 1", "Text" },
                    { new Guid("3cb85182-b2a2-4f02-848a-d6a5285bdf3c"), "a card", "card 1", "Text" },
                    { new Guid("3cf16096-ed81-42df-ae70-02a6972987c4"), "a card", "card 1", "Text" },
                    { new Guid("3d0e0a16-5f5a-43ad-b083-d9ed89b58f3f"), "a card", "card 1", "Text" },
                    { new Guid("3d2c32db-e22b-407c-98cc-c5cf0141022f"), "a card", "card 1", "Text" },
                    { new Guid("3d365960-a661-4483-b8dd-00ad3177327f"), "a card", "card 1", "Text" },
                    { new Guid("3d77e8b7-664d-4b5d-a05e-28cc46f5d9d7"), "a card", "card 1", "Text" },
                    { new Guid("3dc6e2cf-b842-493b-a604-68030f5951b1"), "a card", "card 1", "Text" },
                    { new Guid("3e46a8a8-d0c6-4308-9513-d51221f71618"), "a card", "card 1", "Text" },
                    { new Guid("3e60f7a5-0914-45e6-8930-5201d3ae7860"), "a card", "card 1", "Text" },
                    { new Guid("3ee7a02c-50b2-4f1d-a6c8-2c0a149985fb"), "a card", "card 1", "Text" },
                    { new Guid("3ef99944-83f2-42dd-a818-182c86159eec"), "a card", "card 1", "Text" },
                    { new Guid("3f17ad83-3eb7-4020-bb82-786260267e70"), "a card", "card 1", "Text" },
                    { new Guid("3f90504b-e8d9-4b8d-a7a8-7ba9e964fef9"), "a card", "card 1", "Text" },
                    { new Guid("3f97845b-37c4-45f2-8e60-da73e8389e9b"), "a card", "card 1", "Text" },
                    { new Guid("3fbe6b29-6537-424d-9148-77bb27e7fd1c"), "a card", "card 1", "Text" },
                    { new Guid("3ff66463-e2e9-40bd-b625-c7b2e7f3f4dc"), "a card", "card 1", "Text" },
                    { new Guid("3ff6a6a7-b33e-4a33-905e-b3a1c9608e2d"), "a card", "card 1", "Text" },
                    { new Guid("3ff87b57-62f7-4b99-82fb-13d22012875b"), "a card", "card 1", "Text" },
                    { new Guid("4060c09b-909c-4e2d-a1bb-4551912d40a7"), "a card", "card 1", "Text" },
                    { new Guid("408f06ed-8435-4669-9bfc-48d123ca172f"), "a card", "card 1", "Text" },
                    { new Guid("41108311-59de-474c-9ebb-49cd5390947b"), "a card", "card 1", "Text" },
                    { new Guid("41195bbb-40b6-4eb1-9b6f-f49033e05b37"), "a card", "card 1", "Text" },
                    { new Guid("4135de31-3ab8-4cdf-a6ad-010adee01056"), "a card", "card 1", "Text" },
                    { new Guid("414e0bb8-291d-437d-b94f-d1f28ca2d0cf"), "a card", "card 1", "Text" },
                    { new Guid("417cca07-e260-4887-894b-02e634744e18"), "a card", "card 1", "Text" },
                    { new Guid("41a768a2-3b33-4a52-a6be-bb5399d2810a"), "a card", "card 1", "Text" },
                    { new Guid("41cb0525-249c-4814-8424-cb71490ce3c6"), "a card", "card 1", "Text" },
                    { new Guid("41cde6d9-4e81-4898-97e7-d4b7434fbf52"), "a card", "card 1", "Text" },
                    { new Guid("41ddfebb-f8d7-4974-b4b9-a4da258019f9"), "a card", "card 1", "Text" },
                    { new Guid("41f36ddf-8577-408a-ad4b-ecd953d4e5a1"), "a card", "card 1", "Text" },
                    { new Guid("41fd8c66-58ef-4409-995e-a1cec3a036b0"), "a card", "card 1", "Text" },
                    { new Guid("422398f7-b392-47f1-b2fa-f0db4016eb35"), "a card", "card 1", "Text" },
                    { new Guid("4257d796-e941-418e-a249-7d4a9c640d59"), "a card", "card 1", "Text" },
                    { new Guid("427ecd9f-2ad0-49a5-95b3-fb396ad93add"), "a card", "card 1", "Text" },
                    { new Guid("43a33f0c-75e1-470b-8fc4-a41ffb060f96"), "a card", "card 1", "Text" },
                    { new Guid("43d1b6dc-ddc8-4b80-8108-3af712030d16"), "a card", "card 1", "Text" },
                    { new Guid("441777cf-ac2a-4c17-b255-b607e3daf5ea"), "a card", "card 1", "Text" },
                    { new Guid("4453b68e-f880-4047-9d78-aa16f9f16893"), "a card", "card 1", "Text" },
                    { new Guid("4456b5f7-1f5b-46de-8d43-f7450836e6c0"), "a card", "card 1", "Text" },
                    { new Guid("449c595e-e0e4-4132-a192-ddb522f78842"), "a card", "card 1", "Text" },
                    { new Guid("4511486c-bd20-4d06-8a44-7f2715f2595b"), "a card", "card 1", "Text" },
                    { new Guid("452d0866-2adc-4607-b8bf-b9b2fa49e468"), "a card", "card 1", "Text" },
                    { new Guid("45321e08-0ce1-42dc-9301-774a386a3a02"), "a card", "card 1", "Text" },
                    { new Guid("45585402-9845-444d-8027-b1c98355cb3b"), "a card", "card 1", "Text" },
                    { new Guid("45678767-8c0d-4ac4-9ef9-b3a2ebc93a35"), "a card", "card 1", "Text" },
                    { new Guid("45e5426e-7813-420a-923b-ade2d48ddc09"), "a card", "card 1", "Text" },
                    { new Guid("4603bcb0-6d29-4a43-ba6d-950566df08fc"), "a card", "card 1", "Text" },
                    { new Guid("467762e0-5e97-475d-a84f-586bde9e2fb5"), "a card", "card 1", "Text" },
                    { new Guid("46b36854-751b-45b7-97a3-57c2870d954a"), "a card", "card 1", "Text" },
                    { new Guid("46c33f97-2b74-4527-a391-9f9dbbee2c86"), "a card", "card 1", "Text" },
                    { new Guid("470586c1-ec88-43d9-bc48-3b20e41bb02b"), "a card", "card 1", "Text" },
                    { new Guid("4776e426-198f-49c1-854a-8d8df02215fb"), "a card", "card 1", "Text" },
                    { new Guid("483af7d6-3582-45fe-9150-a41e970bb45d"), "a card", "card 1", "Text" },
                    { new Guid("48799420-a728-47d7-8f0a-8255691ebb3d"), "a card", "card 1", "Text" },
                    { new Guid("48b7912b-ab97-4d3c-ae45-0b7657a1a587"), "a card", "card 1", "Text" },
                    { new Guid("48f5fc4b-2140-4f79-8fa0-7551061adf34"), "a card", "card 1", "Text" },
                    { new Guid("48febc5c-957e-4003-87fc-571f7267525b"), "a card", "card 1", "Text" },
                    { new Guid("49084652-fab4-4511-9b83-7036b7ff19e5"), "a card", "card 1", "Text" },
                    { new Guid("4934e383-a7c6-440a-b54b-c5b57612d95f"), "a card", "card 1", "Text" },
                    { new Guid("4945ac4a-e12d-4dc6-bc21-268736388e99"), "a card", "card 1", "Text" },
                    { new Guid("49ed7258-0ebf-47f9-b268-bedc96b85c74"), "a card", "card 1", "Text" },
                    { new Guid("4ac046c9-63a2-44bb-b5fb-e5f1c5d00d41"), "a card", "card 1", "Text" },
                    { new Guid("4ae0a4dd-b73f-47ba-a455-5d5827eb9f3f"), "a card", "card 1", "Text" },
                    { new Guid("4b784e83-b3fc-4ff0-98a0-e72fab999230"), "a card", "card 1", "Text" },
                    { new Guid("4b7af622-cb3a-48d1-b33e-6387bc7438d8"), "a card", "card 1", "Text" },
                    { new Guid("4b94c6f0-58e8-4ea3-854a-774601bac426"), "a card", "card 1", "Text" },
                    { new Guid("4b9dcb2a-748f-4b9e-9701-3bc1974792c0"), "a card", "card 1", "Text" },
                    { new Guid("4c0e0519-3b34-4864-a335-003c32b0d4d5"), "a card", "card 1", "Text" },
                    { new Guid("4c441abb-e2a0-4d68-a113-2c30021c298c"), "a card", "card 1", "Text" },
                    { new Guid("4d903639-0629-47e0-9717-505cd6594ec9"), "a card", "card 1", "Text" },
                    { new Guid("4dbc6306-1882-41ba-a423-1faf9bfeea80"), "a card", "card 1", "Text" },
                    { new Guid("4e2da2b7-c390-4a5d-9d74-944297be0124"), "a card", "card 1", "Text" },
                    { new Guid("4e4b5c60-d5e1-4290-a1f5-9495d67ba490"), "a card", "card 1", "Text" },
                    { new Guid("4e71984a-5cae-495c-a08a-9d8bb290b435"), "a card", "card 1", "Text" },
                    { new Guid("4e77765d-e512-4332-99ed-ba801c0163ba"), "a card", "card 1", "Text" },
                    { new Guid("4eea7ec5-561a-4426-8705-08a2a8038e02"), "a card", "card 1", "Text" },
                    { new Guid("4f1780fe-2415-4853-ad1d-b63b1ca85804"), "a card", "card 1", "Text" },
                    { new Guid("4f994117-4b01-4e2a-8146-470db1fd85c8"), "a card", "card 1", "Text" },
                    { new Guid("506d137b-7449-4046-bcc5-75982ee69641"), "a card", "card 1", "Text" },
                    { new Guid("51e7a74a-9845-4b22-98a3-88211414cd5a"), "a card", "card 1", "Text" },
                    { new Guid("521daa13-e5dc-4057-aa05-4890096cd323"), "a card", "card 1", "Text" },
                    { new Guid("5240dd62-4e46-4e23-a419-b8da65b3a36a"), "a card", "card 1", "Text" },
                    { new Guid("52f51d65-3094-484d-98e1-ec8650a95739"), "a card", "card 1", "Text" },
                    { new Guid("52f800d6-c663-44cf-bb8a-20a7d291fd10"), "a card", "card 1", "Text" },
                    { new Guid("539cca9d-92a1-4efe-97a9-eba8d9ed0ca3"), "a card", "card 1", "Text" },
                    { new Guid("53c96d7f-353b-4b77-89cc-bd96cc8ccf18"), "a card", "card 1", "Text" },
                    { new Guid("54083618-39ed-4b6c-a157-18851bd97440"), "a card", "card 1", "Text" },
                    { new Guid("54471211-2ff5-4ddc-85f3-0d60bf5c4684"), "a card", "card 1", "Text" },
                    { new Guid("5476b7f5-eb9c-4534-b628-d7a3509b4cd6"), "a card", "card 1", "Text" },
                    { new Guid("54b05e32-3635-4161-b401-445f90a6effd"), "a card", "card 1", "Text" },
                    { new Guid("54f3462d-5fa0-49f2-b8c4-03280e62a671"), "a card", "card 1", "Text" },
                    { new Guid("54f94764-04b4-4571-a448-aafa4486b4c8"), "a card", "card 1", "Text" },
                    { new Guid("55128586-9421-409c-8a54-34df6ff1a40b"), "a card", "card 1", "Text" },
                    { new Guid("5563aa98-2d9f-4dad-8a30-648ac7a32348"), "a card", "card 1", "Text" },
                    { new Guid("55e73bdb-1a30-4a4a-8b80-e1acee7bbc41"), "a card", "card 1", "Text" },
                    { new Guid("568d9d19-bf02-42bb-b23c-fcfbdc695352"), "a card", "card 1", "Text" },
                    { new Guid("568e5360-ac72-4908-84a8-d5e57bcbba33"), "a card", "card 1", "Text" },
                    { new Guid("56986fec-1797-41d0-892a-44a5070aaabd"), "a card", "card 1", "Text" },
                    { new Guid("56feb2c9-c84f-413a-9db6-be4a1368f3dc"), "a card", "card 1", "Text" },
                    { new Guid("573e2247-9c48-422d-9a7d-6d1d52a0514e"), "a card", "card 1", "Text" },
                    { new Guid("57a24b3c-bd5d-438a-8333-c08ca8357c14"), "a card", "card 1", "Text" },
                    { new Guid("57b3fa0a-98c6-4ccb-8552-365591eab194"), "a card", "card 1", "Text" },
                    { new Guid("585d6447-007e-419a-84f5-820c06bbc0b3"), "a card", "card 1", "Text" },
                    { new Guid("586bba5a-b04c-4026-84b1-fc2fb6bd6da6"), "a card", "card 1", "Text" },
                    { new Guid("59970d85-1e6c-4ccf-a5f8-71c0606a4066"), "a card", "card 1", "Text" },
                    { new Guid("599f514b-46e9-4d27-a61b-cae23d694f17"), "a card", "card 1", "Text" },
                    { new Guid("59a72c77-d435-4702-9d0a-8d451e1000ef"), "a card", "card 1", "Text" },
                    { new Guid("5a26f2f4-0126-429d-aa08-23ca802d83e5"), "a card", "card 1", "Text" },
                    { new Guid("5a9c4912-61d8-46a5-8069-98361e71ec09"), "a card", "card 1", "Text" },
                    { new Guid("5b399f21-89e4-455c-8852-5eda8b4394fc"), "a card", "card 1", "Text" },
                    { new Guid("5b43d5c2-1ea2-4e24-a0e2-0e583460612c"), "a card", "card 1", "Text" },
                    { new Guid("5b8e6026-9607-4c3d-8a6a-4b9914df045f"), "a card", "card 1", "Text" },
                    { new Guid("5b93d0d0-fadc-4ad4-832c-a0817fcf0aaa"), "a card", "card 1", "Text" },
                    { new Guid("5bf61381-ddda-4bbc-a4cd-1c678eb28aa0"), "a card", "card 1", "Text" },
                    { new Guid("5c169b82-0445-412c-ae42-73b95055ba90"), "a card", "card 1", "Text" },
                    { new Guid("5c2c3fa1-c28f-4799-a80a-a12f9ac46043"), "a card", "card 1", "Text" },
                    { new Guid("5c344156-6088-4698-a7ac-1ccd5cce8fd8"), "a card", "card 1", "Text" },
                    { new Guid("5c7e66b0-e3d0-4ff8-8785-016eca0bc151"), "a card", "card 1", "Text" },
                    { new Guid("5cb1e64c-317a-48a9-b791-23e65778d5e3"), "a card", "card 1", "Text" },
                    { new Guid("5d14e0bd-59c9-4583-8b62-9ce334d94ccb"), "a card", "card 1", "Text" },
                    { new Guid("5d408b99-fb11-4952-8ffc-3feefde0f856"), "a card", "card 1", "Text" },
                    { new Guid("5d5e5e67-35b5-46bf-a52d-2108f635ae98"), "a card", "card 1", "Text" },
                    { new Guid("5dd44887-8f16-4ffd-bd54-92d85672f3ff"), "a card", "card 1", "Text" },
                    { new Guid("5e2f5e68-c974-4207-938c-2a0956995842"), "a card", "card 1", "Text" },
                    { new Guid("5e393a1e-c546-4e38-a8c0-6b49efe08670"), "a card", "card 1", "Text" },
                    { new Guid("5e43eff2-b58d-409e-9850-609bc3b90eb5"), "a card", "card 1", "Text" },
                    { new Guid("5e4f3f10-2dda-4d1b-93a6-abcae4462896"), "a card", "card 1", "Text" },
                    { new Guid("5ef98250-615d-4fb8-b7e9-3575a4697442"), "a card", "card 1", "Text" },
                    { new Guid("5f27f985-fab8-4fb1-8a44-39572f02a988"), "a card", "card 1", "Text" },
                    { new Guid("5f4e0049-a98e-447d-82af-ce3a840081e1"), "a card", "card 1", "Text" },
                    { new Guid("5f73322a-cbe1-4b84-a7eb-b36c0121f815"), "a card", "card 1", "Text" },
                    { new Guid("5fc67266-9337-464b-8428-cef5c6c78b50"), "a card", "card 1", "Text" },
                    { new Guid("602a8c7d-49a4-46cc-9bbe-575468f963ed"), "a card", "card 1", "Text" },
                    { new Guid("602df369-8e7c-45e4-9108-4ab48a3b5b52"), "a card", "card 1", "Text" },
                    { new Guid("603a24d7-d636-4462-a814-a96d147052c5"), "a card", "card 1", "Text" },
                    { new Guid("6079f483-a339-4ac8-98d7-77562cdb73d9"), "a card", "card 1", "Text" },
                    { new Guid("6096909a-c116-47e6-abd9-5fa9f6a8801a"), "a card", "card 1", "Text" },
                    { new Guid("61a24679-d838-4beb-86b8-83cb7b164c6e"), "a card", "card 1", "Text" },
                    { new Guid("61a30da6-c4ef-4659-89eb-d5946a3d1635"), "a card", "card 1", "Text" },
                    { new Guid("620416f9-66c0-48b4-97cb-f1d00726002e"), "a card", "card 1", "Text" },
                    { new Guid("6207eda3-f8fb-4373-96db-b2875ade97fc"), "a card", "card 1", "Text" },
                    { new Guid("623d161b-8f71-45a7-bdf2-3cc404efccbb"), "a card", "card 1", "Text" },
                    { new Guid("6343600f-cdcf-43c4-9fbe-c16268ca5b82"), "a card", "card 1", "Text" },
                    { new Guid("63a1f60e-a5dd-4eda-a690-ba2796cb6c6e"), "a card", "card 1", "Text" },
                    { new Guid("63ba3c02-1ab6-4bee-a164-986a5437faf7"), "a card", "card 1", "Text" },
                    { new Guid("63fb9398-f7f4-42cd-a7b7-0a15d080755d"), "a card", "card 1", "Text" },
                    { new Guid("64b5a197-82e6-4bd1-8f21-f0adb58e9020"), "a card", "card 1", "Text" },
                    { new Guid("64c98255-e69e-4317-960c-a8f272abc89f"), "a card", "card 1", "Text" },
                    { new Guid("650b90f0-dba1-4f76-b1c0-77c8b26fab65"), "a card", "card 1", "Text" },
                    { new Guid("652d2863-ee40-483e-8b32-308099c404b4"), "a card", "card 1", "Text" },
                    { new Guid("659639ac-4ea1-478a-b4d2-9f2e69f81f95"), "a card", "card 1", "Text" },
                    { new Guid("669f4a8b-8316-4191-9e42-837c16c38129"), "a card", "card 1", "Text" },
                    { new Guid("66ccd804-4898-4801-ad2c-e9c203bb5d4b"), "a card", "card 1", "Text" },
                    { new Guid("66ce74af-7a8e-4d51-9a50-3ad686110099"), "a card", "card 1", "Text" },
                    { new Guid("66e895bd-d18b-4cd5-8205-90c2f44ad851"), "a card", "card 1", "Text" },
                    { new Guid("6703f3d7-6a8d-46b0-8768-01c039bccdde"), "a card", "card 1", "Text" },
                    { new Guid("676197a2-c33a-402d-8d40-39e26d780dce"), "a card", "card 1", "Text" },
                    { new Guid("67daa06c-5480-402f-a106-4a59424541c0"), "a card", "card 1", "Text" },
                    { new Guid("6810dcba-fa22-4492-8150-45a4231e08c4"), "a card", "card 1", "Text" },
                    { new Guid("6880ba51-dc19-4909-a1a3-e020c7314ce9"), "a card", "card 1", "Text" },
                    { new Guid("68a50a97-bbd3-4fc0-8309-372e97cfde32"), "a card", "card 1", "Text" },
                    { new Guid("68f36c2d-fb58-4d01-9fd0-fae49c6b0dba"), "a card", "card 1", "Text" },
                    { new Guid("690d09bb-32c6-47f2-a631-d137c0d62c83"), "a card", "card 1", "Text" },
                    { new Guid("69451a8d-7f49-415c-b67f-9fdd294c0dfc"), "a card", "card 1", "Text" },
                    { new Guid("698dbb54-ef6d-4c50-ab87-bb34182b045a"), "a card", "card 1", "Text" },
                    { new Guid("69a2f340-3cb9-497c-bf70-ba74219cf478"), "a card", "card 1", "Text" },
                    { new Guid("69ad602e-8ce3-48d3-a15b-69e95bca3fca"), "a card", "card 1", "Text" },
                    { new Guid("6a366599-82a2-4855-92ed-207413acf2f5"), "a card", "card 1", "Text" },
                    { new Guid("6a5ac63d-f272-4c6e-aa20-5699cf9ef691"), "a card", "card 1", "Text" },
                    { new Guid("6a7a839e-4c6d-4e8d-8207-3a35e9b261e5"), "a card", "card 1", "Text" },
                    { new Guid("6a89ba14-c1b6-4cea-95f7-cbda02a6135c"), "a card", "card 1", "Text" },
                    { new Guid("6a995fcf-65ed-4b50-9b4e-3000a4ca104a"), "a card", "card 1", "Text" },
                    { new Guid("6aa9e5b5-3668-48f3-9d93-6e82d988d876"), "a card", "card 1", "Text" },
                    { new Guid("6ab37837-d871-420c-b28f-4e0869961873"), "a card", "card 1", "Text" },
                    { new Guid("6b21fee8-81d3-4ddf-b835-b8391bebfba1"), "a card", "card 1", "Text" },
                    { new Guid("6b3023ac-2152-4bd9-8ae5-3603c4a6f2ff"), "a card", "card 1", "Text" },
                    { new Guid("6b6265a7-a9f7-46a8-8d57-639861882a98"), "a card", "card 1", "Text" },
                    { new Guid("6b6fc85e-7e70-40c6-8435-f49de34fda85"), "a card", "card 1", "Text" },
                    { new Guid("6b7a5c7f-ef28-4b49-9146-811448294ced"), "a card", "card 1", "Text" },
                    { new Guid("6ba13e6e-bc4c-464f-a500-959367597da7"), "a card", "card 1", "Text" },
                    { new Guid("6be5f255-bf60-4300-93e6-677c0e6f7790"), "a card", "card 1", "Text" },
                    { new Guid("6c0017a3-8755-4524-b9e5-67b15d7fbda7"), "a card", "card 1", "Text" },
                    { new Guid("6c63381a-62cd-4196-8ab7-8aeeb4449846"), "a card", "card 1", "Text" },
                    { new Guid("6c938a56-9995-424b-9290-ca15eac02f6a"), "a card", "card 1", "Text" },
                    { new Guid("6d21779a-1a7b-414a-bc28-781a4e179e5b"), "a card", "card 1", "Text" },
                    { new Guid("6d3ec15b-6cbb-4696-8ea9-2f885ebbc7f9"), "a card", "card 1", "Text" },
                    { new Guid("6d7f113f-6249-49c9-a4e5-aeb882a77896"), "a card", "card 1", "Text" },
                    { new Guid("6dde77b1-432c-4c74-b41d-a1fc63bff512"), "a card", "card 1", "Text" },
                    { new Guid("6e0215cb-211e-4313-bfa9-fe9871bc9b5b"), "a card", "card 1", "Text" },
                    { new Guid("6e3a3c11-ff1f-4c02-8c45-c78298091cc9"), "a card", "card 1", "Text" },
                    { new Guid("6e88974a-a40a-4761-b2f8-fdc73db2d4d9"), "a card", "card 1", "Text" },
                    { new Guid("6ead35ef-ccb3-4c99-941a-b8348d91aab2"), "a card", "card 1", "Text" },
                    { new Guid("6eb54ef4-365c-444b-81da-f847f22abbb1"), "a card", "card 1", "Text" },
                    { new Guid("6f106fbf-3271-4f0a-88d8-c47e6336abd6"), "a card", "card 1", "Text" },
                    { new Guid("6f58a72f-26fb-43d8-ab67-f9fff5b6ba27"), "a card", "card 1", "Text" },
                    { new Guid("6fae0a03-435b-47da-960b-a968e87b7f3c"), "a card", "card 1", "Text" },
                    { new Guid("6fcb1826-a232-4ece-afe9-3c4f34f902a2"), "a card", "card 1", "Text" },
                    { new Guid("7048bdc9-8544-4ae3-a226-f65dd247357a"), "a card", "card 1", "Text" },
                    { new Guid("7064789e-f7cd-46ec-8d7e-49b35a5bac96"), "a card", "card 1", "Text" },
                    { new Guid("7096e73f-734d-4cc9-81a3-6d69110739cf"), "a card", "card 1", "Text" },
                    { new Guid("70af77ce-b1e4-43a8-a41e-937f92c6a2ed"), "a card", "card 1", "Text" },
                    { new Guid("71b6bb58-8ec6-4fa4-82ad-5af730fd1857"), "a card", "card 1", "Text" },
                    { new Guid("723deaef-8901-493d-80bd-275d51c890b2"), "a card", "card 1", "Text" },
                    { new Guid("725462d4-bc5b-411d-847b-e729660b7886"), "a card", "card 1", "Text" },
                    { new Guid("72a3f830-a37c-47d3-81a9-acb3f24314f2"), "a card", "card 1", "Text" },
                    { new Guid("72d2031c-d163-45d6-a737-df81411acdc7"), "a card", "card 1", "Text" },
                    { new Guid("73ccd908-b986-496b-8073-cc61fce37b7b"), "a card", "card 1", "Text" },
                    { new Guid("74484eb2-dfe0-45cf-83be-559fe64bf46c"), "a card", "card 1", "Text" },
                    { new Guid("745a3b11-d612-4a35-b8a3-d27074586dec"), "a card", "card 1", "Text" },
                    { new Guid("74e5334c-6f20-4d3e-aea4-60bc9d131ecf"), "a card", "card 1", "Text" },
                    { new Guid("74f01878-7519-4a8e-b1cf-175d2d7b8258"), "a card", "card 1", "Text" },
                    { new Guid("7520bcbe-194f-44ce-944e-0c5c1b130ad0"), "a card", "card 1", "Text" },
                    { new Guid("755ca439-3e02-4cbf-b6d6-f8cc227faa57"), "a card", "card 1", "Text" },
                    { new Guid("75a8aa66-04f9-47bd-afdb-156573a77be8"), "a card", "card 1", "Text" },
                    { new Guid("75e91edd-1afb-4105-a927-395688ff6d08"), "a card", "card 1", "Text" },
                    { new Guid("765f849d-c51d-4f43-9242-b2ec5473311f"), "a card", "card 1", "Text" },
                    { new Guid("76b23feb-0b9b-4d0b-9ae6-b9cde950e59a"), "a card", "card 1", "Text" },
                    { new Guid("77314759-95f0-42f9-964d-5da2cf4b4eb3"), "a card", "card 1", "Text" },
                    { new Guid("7783ddb9-49d7-458a-9927-96f26a72fe4f"), "a card", "card 1", "Text" },
                    { new Guid("77ea1cd3-2fe6-4ea0-ac88-b0fce24fa456"), "a card", "card 1", "Text" },
                    { new Guid("787257d5-1116-4986-81a1-a75a48b636c1"), "a card", "card 1", "Text" },
                    { new Guid("78c38344-8a51-4798-8726-2ed403191b98"), "a card", "card 1", "Text" },
                    { new Guid("794a5ddd-a2e0-423b-b849-36ab2b589e47"), "a card", "card 1", "Text" },
                    { new Guid("79576e86-86d6-4cb4-aa80-a8a6a0bc4fe2"), "a card", "card 1", "Text" },
                    { new Guid("79583c64-c324-40cb-8470-0125211fb61a"), "a card", "card 1", "Text" },
                    { new Guid("79b75c45-8adb-4e75-90db-afb15955a806"), "a card", "card 1", "Text" },
                    { new Guid("79c64994-a277-4958-a1cb-eb470f71efac"), "a card", "card 1", "Text" },
                    { new Guid("79e23a24-2efe-4418-91dd-22425cd223de"), "a card", "card 1", "Text" },
                    { new Guid("7b0e47f0-64c9-4e88-8401-868e08fb5ad1"), "a card", "card 1", "Text" },
                    { new Guid("7b91132a-f38c-437a-a7c9-bf24cbf0fd01"), "a card", "card 1", "Text" },
                    { new Guid("7bc0904a-ce0d-4afe-8b23-54c1f55a6181"), "a card", "card 1", "Text" },
                    { new Guid("7bcce654-f09f-42ba-97fb-c9e8ca9b28a2"), "a card", "card 1", "Text" },
                    { new Guid("7d1883f6-f530-4b8b-85b6-ea9f0c60be49"), "a card", "card 1", "Text" },
                    { new Guid("7d55f303-c55a-4050-b373-0e17d4a70203"), "a card", "card 1", "Text" },
                    { new Guid("7d589704-fa04-4b66-8d12-4a6479ea4996"), "a card", "card 1", "Text" },
                    { new Guid("7d784bb6-555c-4f76-b144-f9fdee72a0ac"), "a card", "card 1", "Text" },
                    { new Guid("7dbe44ba-8a83-4086-94a4-b5418b970e56"), "a card", "card 1", "Text" },
                    { new Guid("7e17384b-ad4c-4b5e-b132-37d338cfe4c9"), "a card", "card 1", "Text" },
                    { new Guid("7e42346d-9b61-4b0f-a564-b5e0160bf309"), "a card", "card 1", "Text" },
                    { new Guid("7e450815-ecaf-411e-8f4d-ada6d08772aa"), "a card", "card 1", "Text" },
                    { new Guid("7e6f9768-8cf7-4975-bd07-ab5c12d51b8b"), "a card", "card 1", "Text" },
                    { new Guid("7e7b2b30-67ce-442c-9935-614c78bb8010"), "a card", "card 1", "Text" },
                    { new Guid("7eaa16a1-864d-4cae-a928-9c989344c498"), "a card", "card 1", "Text" },
                    { new Guid("7ebccc93-7451-436a-8953-e1ec87744a78"), "a card", "card 1", "Text" },
                    { new Guid("7f01102f-553b-48a7-bb62-46d973db19aa"), "a card", "card 1", "Text" },
                    { new Guid("7f7a0f2f-11a9-4026-bf16-8e2a648f44a2"), "a card", "card 1", "Text" },
                    { new Guid("7fc369b1-672a-43a9-833c-44e2f49a5739"), "a card", "card 1", "Text" },
                    { new Guid("8012fa04-0dd9-4924-8644-abc3ec673986"), "a card", "card 1", "Text" },
                    { new Guid("809dbc65-43f1-451f-87ab-488a04ad6e1b"), "a card", "card 1", "Text" },
                    { new Guid("809dd057-14bc-4a81-b1b9-a5633dbdbf65"), "a card", "card 1", "Text" },
                    { new Guid("80bfcf9d-eea9-4efa-800c-e87670d90b74"), "a card", "card 1", "Text" },
                    { new Guid("814774c0-3f31-4d67-880c-73d1d3de7f30"), "a card", "card 1", "Text" },
                    { new Guid("814d5162-2675-440c-b6c6-77727c983798"), "a card", "card 1", "Text" },
                    { new Guid("81f1c6f8-68ac-4de6-ad63-5f094dccbb91"), "a card", "card 1", "Text" },
                    { new Guid("82062d17-e47c-42f4-955f-3d8fc5e4eea1"), "a card", "card 1", "Text" },
                    { new Guid("8218543f-09d2-47c5-8d23-bf96f1867331"), "a card", "card 1", "Text" },
                    { new Guid("82bc703d-02b8-4a17-ab03-ade48eac965e"), "a card", "card 1", "Text" },
                    { new Guid("82f90dd8-5cc8-404f-b770-b539b6668249"), "a card", "card 1", "Text" },
                    { new Guid("830610fa-6329-495d-b11a-739c0cb276c1"), "a card", "card 1", "Text" },
                    { new Guid("831fdf24-bc86-4cbc-908a-fd7f339a8cd4"), "a card", "card 1", "Text" },
                    { new Guid("8357cf43-cb12-4d9d-80a5-c1e96120d6df"), "a card", "card 1", "Text" },
                    { new Guid("837f946b-9830-4b7b-844d-709ac55056c7"), "a card", "card 1", "Text" },
                    { new Guid("83985fd4-4dba-49fb-a4f7-cd4ff933a0df"), "a card", "card 1", "Text" },
                    { new Guid("83bbcd50-1c70-44a0-b2d0-d05f5b43fd28"), "a card", "card 1", "Text" },
                    { new Guid("83c7e14f-9c0b-438a-b284-0ba826d157d9"), "a card", "card 1", "Text" },
                    { new Guid("83d061b5-5c25-428c-9a1d-abc06e450d55"), "a card", "card 1", "Text" },
                    { new Guid("8428d7ce-9890-439a-b9ab-870ba46da27a"), "a card", "card 1", "Text" },
                    { new Guid("844ff842-f795-48dd-958e-b03540a59ab0"), "a card", "card 1", "Text" },
                    { new Guid("84b55337-5f63-4626-af29-d4482d01ec4a"), "a card", "card 1", "Text" },
                    { new Guid("8577e2b7-516b-4f81-a7f4-1747b0f74088"), "a card", "card 1", "Text" },
                    { new Guid("85a949e4-c5e1-4d10-9f97-4a3aa30c6eb9"), "a card", "card 1", "Text" },
                    { new Guid("85e9dfff-1731-441b-ae99-06d5b68f88cd"), "a card", "card 1", "Text" },
                    { new Guid("8626c398-dbe0-43a1-b3a2-ccae6590181f"), "a card", "card 1", "Text" },
                    { new Guid("86381b95-de76-41ce-a47c-482eed545151"), "a card", "card 1", "Text" },
                    { new Guid("86683f25-5adb-48af-af55-6b4a0ed25e9f"), "a card", "card 1", "Text" },
                    { new Guid("86a1b4da-4e1b-4958-9cef-77e1394d9825"), "a card", "card 1", "Text" },
                    { new Guid("86b72db7-67ec-4390-821c-c9a1f2cf40e4"), "a card", "card 1", "Text" },
                    { new Guid("86cd0919-7371-45c8-88d0-6cace813cda7"), "a card", "card 1", "Text" },
                    { new Guid("870f339e-2a08-416b-b408-0c4c90447db6"), "a card", "card 1", "Text" },
                    { new Guid("87284cdb-a389-48a6-8837-dc728a5358f1"), "a card", "card 1", "Text" },
                    { new Guid("875bd2d3-e900-4684-a41a-94e082f6ae36"), "a card", "card 1", "Text" },
                    { new Guid("887cbb0d-b8e7-4388-baee-ae19e2dc051b"), "a card", "card 1", "Text" },
                    { new Guid("888a33af-0c3d-49b0-936b-c1ff8fad4160"), "a card", "card 1", "Text" },
                    { new Guid("88b2751f-20ba-4af5-bcec-8e66789a931c"), "a card", "card 1", "Text" },
                    { new Guid("88ba4b8b-4290-49d6-b44b-714059987acc"), "a card", "card 1", "Text" },
                    { new Guid("88d2a1cf-ca20-48e6-8cac-c64dcc073a32"), "a card", "card 1", "Text" },
                    { new Guid("88fd42a8-bdf4-4db6-80e1-10e324cffef3"), "a card", "card 1", "Text" },
                    { new Guid("8908e710-b9af-428f-88c7-eb28c3995c2b"), "a card", "card 1", "Text" },
                    { new Guid("89771797-a8ae-4fe7-a1ab-0e833c484f62"), "a card", "card 1", "Text" },
                    { new Guid("89876df3-a12d-49ae-96b0-0df00bfbf5e7"), "a card", "card 1", "Text" },
                    { new Guid("8988f4dc-07f4-4e70-84f4-95b95796feff"), "a card", "card 1", "Text" },
                    { new Guid("89af2bd1-db46-451c-9c76-76125b95ac5f"), "a card", "card 1", "Text" },
                    { new Guid("89f80233-d9f6-4cf6-b96c-bb48fc7512e6"), "a card", "card 1", "Text" },
                    { new Guid("89fb04d2-146a-4e6d-8a5b-07d17d350cec"), "a card", "card 1", "Text" },
                    { new Guid("8a0c07e6-e3f0-4b86-9236-af6e18406dfd"), "a card", "card 1", "Text" },
                    { new Guid("8a2882a3-648f-45f9-aa8d-ececc5ed74ed"), "a card", "card 1", "Text" },
                    { new Guid("8a305670-ae99-4060-895e-e8e259d2e890"), "a card", "card 1", "Text" },
                    { new Guid("8a3af5ef-8ec4-4234-b906-76a4fc48af53"), "a card", "card 1", "Text" },
                    { new Guid("8a642185-2b6e-45b3-8098-51e5e3b0a9bd"), "a card", "card 1", "Text" },
                    { new Guid("8a7a1b18-b926-4581-bfb5-55d58a7dfc8f"), "a card", "card 1", "Text" },
                    { new Guid("8ab32e89-aaf0-4aa7-9fdf-16aa1628b184"), "a card", "card 1", "Text" },
                    { new Guid("8b09af3f-02e9-4aa5-9f51-9677c750df01"), "a card", "card 1", "Text" },
                    { new Guid("8b6bb552-dd78-4350-9718-3c0dbbc1f3c0"), "a card", "card 1", "Text" },
                    { new Guid("8b7fe02c-02b4-4047-844c-4dc27e5272a1"), "a card", "card 1", "Text" },
                    { new Guid("8be6e8a5-3514-41fb-a183-2314bb723f5f"), "a card", "card 1", "Text" },
                    { new Guid("8c5163c3-3be6-4a0a-91d3-a5cc9e94960b"), "a card", "card 1", "Text" },
                    { new Guid("8d29fd19-97d9-44b2-8e16-ba53da11c9fd"), "a card", "card 1", "Text" },
                    { new Guid("8d6c756c-46dd-4e3a-bc71-512b4fedc501"), "a card", "card 1", "Text" },
                    { new Guid("8dabe2d3-6b0d-462c-a074-54f30605d303"), "a card", "card 1", "Text" },
                    { new Guid("8dcde802-c524-48be-a049-ce57cf83e6c3"), "a card", "card 1", "Text" },
                    { new Guid("8e5ae901-f80e-4ea4-a2c6-84849c655619"), "a card", "card 1", "Text" },
                    { new Guid("8ea96071-b11e-409f-8a63-ebdab7cafc72"), "a card", "card 1", "Text" },
                    { new Guid("8ec6d789-734e-4f49-b394-7d1768df4171"), "a card", "card 1", "Text" },
                    { new Guid("8ecbd553-3c0f-46fe-9e61-7275b90d8b32"), "a card", "card 1", "Text" },
                    { new Guid("8fa23a72-225d-4d11-90d8-361c50337050"), "a card", "card 1", "Text" },
                    { new Guid("8fa606a9-a929-43d6-b35d-bf76b9386bf5"), "a card", "card 1", "Text" },
                    { new Guid("902d92c0-4b6f-44f4-857d-e46d30292049"), "a card", "card 1", "Text" },
                    { new Guid("903a5330-4d14-42ed-8896-86e26210933f"), "a card", "card 1", "Text" },
                    { new Guid("904b0552-d58a-4731-bd00-014221566ca5"), "a card", "card 1", "Text" },
                    { new Guid("9053957f-d257-4601-86d0-b2e8af9b3d8c"), "a card", "card 1", "Text" },
                    { new Guid("906187f2-d356-4e8b-a9da-b26be583cc01"), "a card", "card 1", "Text" },
                    { new Guid("90b14adf-3c9a-4d19-82b7-1a637e1857fe"), "a card", "card 1", "Text" },
                    { new Guid("913ea6f6-f52c-42a5-83b1-6a3cfeb03ded"), "a card", "card 1", "Text" },
                    { new Guid("914f15e9-34c5-4442-b8d3-0088bc4ec506"), "a card", "card 1", "Text" },
                    { new Guid("9166560e-0bbc-4360-977d-77d74e743c26"), "a card", "card 1", "Text" },
                    { new Guid("9195b20c-427d-4741-ab8a-f670afad3009"), "a card", "card 1", "Text" },
                    { new Guid("9205d916-75b1-4259-ae01-85554e76f2d4"), "a card", "card 1", "Text" },
                    { new Guid("92161bf5-a77e-4ada-b52f-da49c0f11fac"), "a card", "card 1", "Text" },
                    { new Guid("923c414a-faa8-4005-93da-dfe508059dab"), "a card", "card 1", "Text" },
                    { new Guid("92617358-a655-4a9c-8888-0785ac6edbfd"), "a card", "card 1", "Text" },
                    { new Guid("9262c209-1893-4140-a771-9ea7d5a8837e"), "a card", "card 1", "Text" },
                    { new Guid("9313ba2d-7e08-4cea-b007-99d5e25b3d93"), "a card", "card 1", "Text" },
                    { new Guid("9365e71d-7eb5-4fe5-8f85-41249181f66e"), "a card", "card 1", "Text" },
                    { new Guid("93685ad2-d175-4991-a458-2a4a83604bc2"), "a card", "card 1", "Text" },
                    { new Guid("9399cfa5-e322-4cb7-8d06-0320d70d8931"), "a card", "card 1", "Text" },
                    { new Guid("93c7994a-0513-4189-9b9c-d907dee9ac40"), "a card", "card 1", "Text" },
                    { new Guid("93d9c288-8b8b-47ce-9126-a0f7135cfed4"), "a card", "card 1", "Text" },
                    { new Guid("93fe8e7c-38b4-4c4b-b941-e8d478bab140"), "a card", "card 1", "Text" },
                    { new Guid("949592c6-7bd8-48d7-964e-e1f46a6eca8f"), "a card", "card 1", "Text" },
                    { new Guid("94efb361-b0f5-4088-82fd-bd6ad06f9968"), "a card", "card 1", "Text" },
                    { new Guid("95603c7e-3045-4172-8cb0-1778d7086ddb"), "a card", "card 1", "Text" },
                    { new Guid("95b26ced-a217-413a-8793-8288ad4620af"), "a card", "card 1", "Text" },
                    { new Guid("961a5f60-f6f6-4dba-9c6e-c69fe7adaa3a"), "a card", "card 1", "Text" },
                    { new Guid("9621729a-1441-4ee0-99f7-778717395be6"), "a card", "card 1", "Text" },
                    { new Guid("968216fc-cb37-415a-8dc6-2b84390f7f7b"), "a card", "card 1", "Text" },
                    { new Guid("96ca8dba-fff7-46b7-806a-0517a9e83483"), "a card", "card 1", "Text" },
                    { new Guid("97278db2-7153-41b2-a552-67308dcd1036"), "a card", "card 1", "Text" },
                    { new Guid("97422f09-6c84-45d6-be0a-798315802c21"), "a card", "card 1", "Text" },
                    { new Guid("97a01721-3147-4c02-a0c9-61e6a42eabbc"), "a card", "card 1", "Text" },
                    { new Guid("97ec2904-13c3-4ac3-9bfa-84f1e3b410a8"), "a card", "card 1", "Text" },
                    { new Guid("98045a7f-2f87-4489-94ca-08ca11059442"), "a card", "card 1", "Text" },
                    { new Guid("981a272d-00b8-40a5-88b8-88fdbc1d0167"), "a card", "card 1", "Text" },
                    { new Guid("9833945d-baa8-421f-98c6-990e5fea3105"), "a card", "card 1", "Text" },
                    { new Guid("988b966b-902b-48b3-9d77-78549c63867b"), "a card", "card 1", "Text" },
                    { new Guid("9895085f-c8df-46ad-b394-32bbba9df751"), "a card", "card 1", "Text" },
                    { new Guid("9895bd17-d5fa-49d2-9c4b-e486872571cb"), "a card", "card 1", "Text" },
                    { new Guid("9922e703-5213-4a72-8439-d90899989256"), "a card", "card 1", "Text" },
                    { new Guid("993433b6-45a0-4b20-886f-cc302ee6642a"), "a card", "card 1", "Text" },
                    { new Guid("99aa8e4a-1d19-402c-a06d-defb35ccf1f5"), "a card", "card 1", "Text" },
                    { new Guid("99cc5028-c62d-4d6c-879d-440e438ebaf4"), "a card", "card 1", "Text" },
                    { new Guid("99f257c2-9321-4612-a38a-c29070c7145a"), "a card", "card 1", "Text" },
                    { new Guid("9a0e8988-58f3-474f-a54d-1d93cec774d3"), "a card", "card 1", "Text" },
                    { new Guid("9a313f44-5338-4248-b7c3-b8849a05c300"), "a card", "card 1", "Text" },
                    { new Guid("9a989a79-692a-4b3e-8d46-ed56af281131"), "a card", "card 1", "Text" },
                    { new Guid("9ad2a827-ff1d-43cf-bede-e4603fcf3e6d"), "a card", "card 1", "Text" },
                    { new Guid("9af27543-fd8c-42dc-9d8e-7250568f8357"), "a card", "card 1", "Text" },
                    { new Guid("9b6ced47-0889-483f-8f44-b8388d504911"), "a card", "card 1", "Text" },
                    { new Guid("9b7f0aec-cb23-4f77-be12-20e013dfe5b8"), "a card", "card 1", "Text" },
                    { new Guid("9b82ad6a-908b-46d3-a7d2-04ca9c699f60"), "a card", "card 1", "Text" },
                    { new Guid("9b8968f3-54cc-4fd7-849a-0464f953de05"), "a card", "card 1", "Text" },
                    { new Guid("9bab3034-e7b1-4ca3-812f-c9452c0ab32d"), "a card", "card 1", "Text" },
                    { new Guid("9c2b9bea-886f-4716-90e8-d58915b0f0a1"), "a card", "card 1", "Text" },
                    { new Guid("9c4060e8-ff5e-416f-8ebf-959cada59153"), "a card", "card 1", "Text" },
                    { new Guid("9c6cdde0-9ab8-4d33-8531-3757a8ce781a"), "a card", "card 1", "Text" },
                    { new Guid("9c9a7a1b-8988-4679-be3d-5f12b49fa81e"), "a card", "card 1", "Text" },
                    { new Guid("9cd6aba3-5dd9-43f8-a2d3-d1b3f218a367"), "a card", "card 1", "Text" },
                    { new Guid("9d1526b0-17d0-44cc-bbbf-80dc3c21c7f3"), "a card", "card 1", "Text" },
                    { new Guid("9d19a549-bfba-42a5-a826-cc1e273aec3c"), "a card", "card 1", "Text" },
                    { new Guid("9d1ca452-c385-4365-be10-d66b9470f72c"), "a card", "card 1", "Text" },
                    { new Guid("9d71b61d-4522-42aa-b066-eca80cf06548"), "a card", "card 1", "Text" },
                    { new Guid("9da63b09-30b7-446a-987d-bc40054bcb07"), "a card", "card 1", "Text" },
                    { new Guid("9dd0df2a-f484-4499-a44f-9a44645deacd"), "a card", "card 1", "Text" },
                    { new Guid("9e1ea030-1080-455a-8081-62db7ca11cdc"), "a card", "card 1", "Text" },
                    { new Guid("9f37d7a7-6410-4fa4-abb9-270b7361471a"), "a card", "card 1", "Text" },
                    { new Guid("9f4860bc-fc18-4356-b734-e8875fcd0e2f"), "a card", "card 1", "Text" },
                    { new Guid("9feea11a-70be-4e03-b470-48f0be1241ef"), "a card", "card 1", "Text" },
                    { new Guid("a02b1f22-d317-47f1-9d1a-a073620d1ab8"), "a card", "card 1", "Text" },
                    { new Guid("a030d3d5-275f-4c7d-831d-8cac7c025562"), "a card", "card 1", "Text" },
                    { new Guid("a0525451-95d3-4d81-9674-9d6f3dabd374"), "a card", "card 1", "Text" },
                    { new Guid("a09eb6f6-dc61-4b2c-9ab8-44b7e7bb0586"), "a card", "card 1", "Text" },
                    { new Guid("a0f1f4af-20f5-4471-8b7b-193be7defd1c"), "a card", "card 1", "Text" },
                    { new Guid("a1044c8c-6719-42b2-8a70-4b8ae90ef4e1"), "a card", "card 1", "Text" },
                    { new Guid("a119b0c1-f259-45df-9c25-6dcbed9e649a"), "a card", "card 1", "Text" },
                    { new Guid("a14fa821-2b29-4907-98e4-17b20f864339"), "a card", "card 1", "Text" },
                    { new Guid("a1d04acc-3764-4ce6-8a94-52e5284a4657"), "a card", "card 1", "Text" },
                    { new Guid("a1ddd176-36e5-4466-b590-dec0ed7ee327"), "a card", "card 1", "Text" },
                    { new Guid("a236f3bd-6081-4036-94e7-eb757156cd8f"), "a card", "card 1", "Text" },
                    { new Guid("a26fd8bc-81e2-40fa-bb4b-33ffee23813b"), "a card", "card 1", "Text" },
                    { new Guid("a2c0c466-8fae-40ac-a74d-eb07808fc0f8"), "a card", "card 1", "Text" },
                    { new Guid("a2f3b6bf-3b76-4b9d-a9f1-441233bc6cc7"), "a card", "card 1", "Text" },
                    { new Guid("a33a2cfa-a262-4cbc-a2d7-fb16316fd6b8"), "a card", "card 1", "Text" },
                    { new Guid("a348904f-8b3e-4725-884e-71a9c653a9f7"), "a card", "card 1", "Text" },
                    { new Guid("a4266d01-5175-467f-be1b-25b10205df67"), "a card", "card 1", "Text" },
                    { new Guid("a4355b2e-f872-4523-badf-dd1064931b70"), "a card", "card 1", "Text" },
                    { new Guid("a475f992-8664-418b-a482-190cb1737be7"), "a card", "card 1", "Text" },
                    { new Guid("a479d3fd-5a0e-4952-84ab-2f9a2bdf23fe"), "a card", "card 1", "Text" },
                    { new Guid("a4904da7-a1ad-4c4a-9692-3a1b09266daa"), "a card", "card 1", "Text" },
                    { new Guid("a4986837-a820-4e84-9206-14f2bcce4b4b"), "a card", "card 1", "Text" },
                    { new Guid("a4cd8a35-0ecb-4cc9-a700-bea74bdcc235"), "a card", "card 1", "Text" },
                    { new Guid("a4f7d07d-66f7-4b8b-a582-5658d82a034e"), "a card", "card 1", "Text" },
                    { new Guid("a51f83d6-6031-4095-813c-a2598b4adcaf"), "a card", "card 1", "Text" },
                    { new Guid("a6280b76-a27b-4961-98f3-069f0aab0b73"), "a card", "card 1", "Text" },
                    { new Guid("a64200bf-21ef-4d7b-a4a9-83b02dfc335a"), "a card", "card 1", "Text" },
                    { new Guid("a663dedc-a0ef-46fb-b09c-7d8d3ff53950"), "a card", "card 1", "Text" },
                    { new Guid("a6793e53-ea1e-4024-aea0-2eebd8072ac1"), "a card", "card 1", "Text" },
                    { new Guid("a6cf734c-2892-4e9b-8a11-310cac331d5d"), "a card", "card 1", "Text" },
                    { new Guid("a71b074d-7b94-433d-8723-7433e7d799af"), "a card", "card 1", "Text" },
                    { new Guid("a79ce4e7-ebc7-4360-883e-d1542a31f96f"), "a card", "card 1", "Text" },
                    { new Guid("a813f092-06fd-482b-ac90-9cac37ad4a12"), "a card", "card 1", "Text" },
                    { new Guid("a855f09d-06f4-405a-939e-a2178ef3e141"), "a card", "card 1", "Text" },
                    { new Guid("a8d6c702-ffb0-49e0-9f1b-60c7292ed9dd"), "a card", "card 1", "Text" },
                    { new Guid("a955abe9-2223-4005-a4fc-4364a6ee5442"), "a card", "card 1", "Text" },
                    { new Guid("a9575c57-23f6-45d6-a204-7944d8b7e3be"), "a card", "card 1", "Text" },
                    { new Guid("aa109aef-f168-40b0-a30f-295f5d6d697e"), "a card", "card 1", "Text" },
                    { new Guid("aabed9cd-00e2-404d-8200-421d5d99b20b"), "a card", "card 1", "Text" },
                    { new Guid("aad6237b-fb4c-4b78-a02e-0d415ff9b1cc"), "a card", "card 1", "Text" },
                    { new Guid("aae9db66-edab-4fe5-bde9-69ef9653b7b8"), "a card", "card 1", "Text" },
                    { new Guid("ab01fd94-fbda-493b-b32f-dc1e2b31b3ea"), "a card", "card 1", "Text" },
                    { new Guid("ab320ac4-d5f4-4f31-8f4f-3ac5c8437150"), "a card", "card 1", "Text" },
                    { new Guid("ab56292e-f6fc-4353-8778-8f08c788c1bb"), "a card", "card 1", "Text" },
                    { new Guid("abb03eb3-4ea5-44ab-b5ee-f6b66434a976"), "a card", "card 1", "Text" },
                    { new Guid("abca27d1-9088-4b9c-b170-39ba71ad04e3"), "a card", "card 1", "Text" },
                    { new Guid("abfeab3d-e168-4fb3-b08b-5626ffeb8a7b"), "a card", "card 1", "Text" },
                    { new Guid("ac5da383-41c0-4a6f-8df6-ddcaac8fb20e"), "a card", "card 1", "Text" },
                    { new Guid("ac5ec140-81ab-40ea-99f3-de5b982a4522"), "a card", "card 1", "Text" },
                    { new Guid("ac618b26-a9d1-4314-8208-ec791ab5d57a"), "a card", "card 1", "Text" },
                    { new Guid("ac9a0ce9-848a-401e-b634-4e7864328ab1"), "a card", "card 1", "Text" },
                    { new Guid("accbe5dc-3d03-4fdd-8ebf-5c0a7a5ac86f"), "a card", "card 1", "Text" },
                    { new Guid("ad18e5ac-7b8d-48ec-826a-69488c0b0b57"), "a card", "card 1", "Text" },
                    { new Guid("ad29bac3-c184-4c5d-839c-973e38d4476f"), "a card", "card 1", "Text" },
                    { new Guid("ad2dc500-ff4f-4bac-9f63-7d7565f1388f"), "a card", "card 1", "Text" },
                    { new Guid("ad95e387-2a0c-4176-8efd-7fc8ef963aff"), "a card", "card 1", "Text" },
                    { new Guid("ada723b1-6e0a-4152-8985-c37800816c72"), "a card", "card 1", "Text" },
                    { new Guid("add4dc09-4a00-48e5-b679-ef6f53258db3"), "a card", "card 1", "Text" },
                    { new Guid("addedd2b-539f-4799-84c6-60da86db82f4"), "a card", "card 1", "Text" },
                    { new Guid("ade88ab4-f6c6-4589-b426-febbc713f981"), "a card", "card 1", "Text" },
                    { new Guid("ae5a5a81-7c56-4487-a4d5-1eff7fd54915"), "a card", "card 1", "Text" },
                    { new Guid("ae7d8407-f96b-4c8f-95ff-6eefa388dd9d"), "a card", "card 1", "Text" },
                    { new Guid("aed2e2c4-e0f1-435d-b996-e098089e4b6c"), "a card", "card 1", "Text" },
                    { new Guid("aef42696-3f95-4bbb-8a42-85388f0b8e5c"), "a card", "card 1", "Text" },
                    { new Guid("af567a4a-7b91-41cf-b41d-6a3d8338269b"), "a card", "card 1", "Text" },
                    { new Guid("af617cb1-3196-4943-9608-a3ec61db0ce7"), "a card", "card 1", "Text" },
                    { new Guid("af8d2036-1ff5-4071-becd-e3b2f3a13a34"), "a card", "card 1", "Text" },
                    { new Guid("b015d297-3ea1-4ae6-bc13-eb5038d1fbee"), "a card", "card 1", "Text" },
                    { new Guid("b07dd9ec-9609-4d10-b108-fcbbb76c4cc0"), "a card", "card 1", "Text" },
                    { new Guid("b0e09f08-4300-4739-b022-6d1068c4bb7e"), "a card", "card 1", "Text" },
                    { new Guid("b1079477-4157-48e9-80b1-a1a19a2d3bc4"), "a card", "card 1", "Text" },
                    { new Guid("b1377f75-41bf-4dbb-bbf0-a75a98b2acef"), "a card", "card 1", "Text" },
                    { new Guid("b13f9bee-7419-4631-a5d8-4c8a54364047"), "a card", "card 1", "Text" },
                    { new Guid("b1913efa-b063-4fb7-a3b7-2dfa62437ad0"), "a card", "card 1", "Text" },
                    { new Guid("b1e4e419-5325-45c5-a965-f5fa299004ce"), "a card", "card 1", "Text" },
                    { new Guid("b21c20c3-7219-43a4-8aa3-bb2f9e1e39c5"), "a card", "card 1", "Text" },
                    { new Guid("b2afa0ae-3ee8-4571-a062-421b9a345371"), "a card", "card 1", "Text" },
                    { new Guid("b2eb09be-d02d-433c-ab26-3414a0f074d9"), "a card", "card 1", "Text" },
                    { new Guid("b3651821-878d-48d6-ab5b-6cf25c1bb1ff"), "a card", "card 1", "Text" },
                    { new Guid("b4980246-f6ca-4d16-8aa9-fa6a9fef029f"), "a card", "card 1", "Text" },
                    { new Guid("b5620843-01ad-4935-be2f-596d40b9c8fb"), "a card", "card 1", "Text" },
                    { new Guid("b5834387-bff7-449a-8eb8-f9ec4544abb5"), "a card", "card 1", "Text" },
                    { new Guid("b5bc9055-998c-435a-b848-d1f6a8abcc3b"), "a card", "card 1", "Text" },
                    { new Guid("b6243ee9-618f-4ff1-998d-6f9e7627bd8c"), "a card", "card 1", "Text" },
                    { new Guid("b6ce0ad3-d71e-4fef-9a64-ac3579a76b36"), "a card", "card 1", "Text" },
                    { new Guid("b6ea2611-f9dd-4997-b1de-012d5486869b"), "a card", "card 1", "Text" },
                    { new Guid("b735a01f-b593-4b9d-a668-eeb82e287a31"), "a card", "card 1", "Text" },
                    { new Guid("b7a7ac99-18fc-4239-bc73-eece293ac47b"), "a card", "card 1", "Text" },
                    { new Guid("b7b10b46-0b1d-4396-b5c9-9f29bb6e435b"), "a card", "card 1", "Text" },
                    { new Guid("b7c4a18c-b9fb-44be-8213-29661940720f"), "a card", "card 1", "Text" },
                    { new Guid("b81a0443-3f97-45da-8a69-af43090b457e"), "a card", "card 1", "Text" },
                    { new Guid("b8403c50-12da-44f6-aca3-67110ca0c1cf"), "a card", "card 1", "Text" },
                    { new Guid("b8ddb7d1-d788-45d9-8554-f862bbcf52af"), "a card", "card 1", "Text" },
                    { new Guid("b909c919-98c0-4f25-8ee7-f538b695cb2c"), "a card", "card 1", "Text" },
                    { new Guid("b917cb13-620e-42ee-ada7-6d7f371c7a63"), "a card", "card 1", "Text" },
                    { new Guid("b92e538f-fe19-421c-af3a-ab9a07b14271"), "a card", "card 1", "Text" },
                    { new Guid("b9a88b04-488a-4794-9d62-94f6c4b7210f"), "a card", "card 1", "Text" },
                    { new Guid("b9bcbcc2-1f53-4c97-92c6-7916ab5803bd"), "a card", "card 1", "Text" },
                    { new Guid("b9db51bd-3230-4af3-b682-f60e60f10f6f"), "a card", "card 1", "Text" },
                    { new Guid("b9fb223a-4e3d-418c-b6ae-dd3e4a1a8e4b"), "a card", "card 1", "Text" },
                    { new Guid("babc4b84-e6d9-4938-b5fc-8513f6fae194"), "a card", "card 1", "Text" },
                    { new Guid("bb34f3b5-e4e5-4dd7-8e22-23095141e683"), "a card", "card 1", "Text" },
                    { new Guid("bb439f7e-db3c-442b-97b9-f5bb641af905"), "a card", "card 1", "Text" },
                    { new Guid("bbe7fbe2-0922-4430-9687-7535ddbc472d"), "a card", "card 1", "Text" },
                    { new Guid("bbea7421-af61-4fd3-bd63-990ba26516c7"), "a card", "card 1", "Text" },
                    { new Guid("bbef105d-aa6e-40e5-a508-cb78d9c1d5b5"), "a card", "card 1", "Text" },
                    { new Guid("bce84a4e-0ae7-4b22-931a-5b7bb8081be7"), "a card", "card 1", "Text" },
                    { new Guid("bd4cc1f1-961e-41b3-8e54-486af7db3229"), "a card", "card 1", "Text" },
                    { new Guid("bdd74d9a-f6d3-4b2d-9d6d-06bb88339ec0"), "a card", "card 1", "Text" },
                    { new Guid("be53fd0a-4291-47ae-a4c7-7fb3b3040b1d"), "a card", "card 1", "Text" },
                    { new Guid("be5a289e-7290-4243-a984-8082700ecca3"), "a card", "card 1", "Text" },
                    { new Guid("bee47e17-7bbd-41ac-91ce-f5e34d452628"), "a card", "card 1", "Text" },
                    { new Guid("bef03eeb-aa24-400e-9e8b-b6ae0a82a4c0"), "a card", "card 1", "Text" },
                    { new Guid("beffdaf5-a1f2-4fc2-8d6d-593bea8a3c7c"), "a card", "card 1", "Text" },
                    { new Guid("bf65ea74-ac18-42e7-a6c7-69a924905765"), "a card", "card 1", "Text" },
                    { new Guid("bf9ce839-db0f-4d32-b807-488869c0f4f4"), "a card", "card 1", "Text" },
                    { new Guid("bfd4df73-403e-4d33-adbd-6e1fd74716e0"), "a card", "card 1", "Text" },
                    { new Guid("bfd9573b-ab90-4e69-9edf-febcad8cbaeb"), "a card", "card 1", "Text" },
                    { new Guid("bfeecd10-a44e-4271-82e0-859ea60b54e2"), "a card", "card 1", "Text" },
                    { new Guid("c00bcc2b-b938-44a5-9c01-6d4498e3e117"), "a card", "card 1", "Text" },
                    { new Guid("c0639c2e-abc6-412d-b406-3c90e54585f7"), "a card", "card 1", "Text" },
                    { new Guid("c0e11583-84f6-4b15-bd0c-b1bb192a0751"), "a card", "card 1", "Text" },
                    { new Guid("c11a7aee-5178-4282-b387-16acc8361225"), "a card", "card 1", "Text" },
                    { new Guid("c128202e-9e24-4f4f-b9cb-3bad0540b9c8"), "a card", "card 1", "Text" },
                    { new Guid("c1888488-590b-45ca-8bc6-f8c699961c08"), "a card", "card 1", "Text" },
                    { new Guid("c190548f-4cdf-42d9-a2d3-bc0ba7ee5c40"), "a card", "card 1", "Text" },
                    { new Guid("c1f4fa52-e804-4ebe-afb7-1f5f7d3c3155"), "a card", "card 1", "Text" },
                    { new Guid("c21c43e9-bd88-403f-ac45-d7acdce1a875"), "a card", "card 1", "Text" },
                    { new Guid("c2459bf9-482e-43ab-829c-7a8b43f2c7bd"), "a card", "card 1", "Text" },
                    { new Guid("c3582ed9-4b93-442f-be76-e3f662fd0aaa"), "a card", "card 1", "Text" },
                    { new Guid("c3bb2acc-3b55-444e-b8d5-14ee393011cd"), "a card", "card 1", "Text" },
                    { new Guid("c3d6af81-f54f-4dd3-9fb6-35e05df6dd9b"), "a card", "card 1", "Text" },
                    { new Guid("c42404f4-4a3f-4135-bc0b-b1b80f614f5b"), "a card", "card 1", "Text" },
                    { new Guid("c4454747-1414-43ff-a5a8-9820a6026ce3"), "a card", "card 1", "Text" },
                    { new Guid("c464ca0b-786c-49a5-89f0-3e706eeab334"), "a card", "card 1", "Text" },
                    { new Guid("c46ee182-222c-402d-8640-422f0b598b1b"), "a card", "card 1", "Text" },
                    { new Guid("c48bcfd2-70af-45c3-a903-ba27214a6a7b"), "a card", "card 1", "Text" },
                    { new Guid("c4b5f391-a2cf-4cf7-aa59-7aa8d8e813f5"), "a card", "card 1", "Text" },
                    { new Guid("c5493ec3-bf9a-498e-8d66-bebe512a7bd7"), "a card", "card 1", "Text" },
                    { new Guid("c5751f30-8446-4fc5-b64e-0add4155f608"), "a card", "card 1", "Text" },
                    { new Guid("c59bf423-0e44-4efa-8e87-9e5abfd01ce2"), "a card", "card 1", "Text" },
                    { new Guid("c5be1e88-557a-4242-b39e-7e458762ec43"), "a card", "card 1", "Text" },
                    { new Guid("c5d448b7-a2b7-4cf0-b3bd-5651e4281e3a"), "a card", "card 1", "Text" },
                    { new Guid("c6049188-9e77-4b78-8902-70ab95e6d43a"), "a card", "card 1", "Text" },
                    { new Guid("c612c09f-d58a-436e-8b85-d9e3a6cd58e8"), "a card", "card 1", "Text" },
                    { new Guid("c6448e42-f2b1-46f7-ba66-d75bf70bf9e7"), "a card", "card 1", "Text" },
                    { new Guid("c691b401-f6d2-4859-82a8-f30b814328f0"), "a card", "card 1", "Text" },
                    { new Guid("c6dc9c1b-f80c-4357-9979-168c8bdba5a6"), "a card", "card 1", "Text" },
                    { new Guid("c73448dc-a606-4b2b-9956-2cbb19099611"), "a card", "card 1", "Text" },
                    { new Guid("c759983c-892a-4bd6-8db5-a85527dd32f4"), "a card", "card 1", "Text" },
                    { new Guid("c7e173ed-db61-4bc1-9858-f0a6d9385882"), "a card", "card 1", "Text" },
                    { new Guid("c7fe6951-d49c-4d05-bb37-f158a51cd820"), "a card", "card 1", "Text" },
                    { new Guid("c814a18b-2879-41b9-8232-10cb86ef5731"), "a card", "card 1", "Text" },
                    { new Guid("c81f323d-ca2f-4ee7-8661-8b1d9db94d04"), "a card", "card 1", "Text" },
                    { new Guid("c81f3c5e-2e31-4af8-abef-195e07796b90"), "a card", "card 1", "Text" },
                    { new Guid("c851ae44-54b0-46a1-8ac4-9bbffa727617"), "a card", "card 1", "Text" },
                    { new Guid("c86815a8-e5bc-4c37-9f82-08de129df19e"), "a card", "card 1", "Text" },
                    { new Guid("c88e6809-13a6-4a3b-a863-5bcf65a74092"), "a card", "card 1", "Text" },
                    { new Guid("c8af3668-ab7a-4b8e-95b9-063faab35ffd"), "a card", "card 1", "Text" },
                    { new Guid("c8b0ee91-2ca1-4a72-b4b0-b741d42d910d"), "a card", "card 1", "Text" },
                    { new Guid("c8d5160d-05f5-4c48-a14e-5a86a8e17377"), "a card", "card 1", "Text" },
                    { new Guid("c94ab4e1-c6c2-4c0d-9e65-829d4c2d6e1f"), "a card", "card 1", "Text" },
                    { new Guid("c96733be-f258-4a26-83db-f632d161af10"), "a card", "card 1", "Text" },
                    { new Guid("c96bf380-6f6f-4d66-b2ca-3f079a3b0005"), "a card", "card 1", "Text" },
                    { new Guid("c97e58c6-9658-411a-a7be-f7e3671b064e"), "a card", "card 1", "Text" },
                    { new Guid("c9cf6d0e-de9e-40c3-b3a1-dcc196af8aa9"), "a card", "card 1", "Text" },
                    { new Guid("ca3b86a9-d7d7-4972-9f72-7784090e9f47"), "a card", "card 1", "Text" },
                    { new Guid("ca48de01-4232-40d5-b009-d4fcb1fd7f86"), "a card", "card 1", "Text" },
                    { new Guid("ca6c2810-9f59-4748-87db-661377ff1181"), "a card", "card 1", "Text" },
                    { new Guid("cacf676d-9885-4a1b-8d14-d274dc061769"), "a card", "card 1", "Text" },
                    { new Guid("cae2602f-8424-4065-af7d-90fdf77f2b3a"), "a card", "card 1", "Text" },
                    { new Guid("caf11e41-b673-4619-99fa-94c6a52545f8"), "a card", "card 1", "Text" },
                    { new Guid("cbb4c3b3-7862-434b-8dde-81459c7789ac"), "a card", "card 1", "Text" },
                    { new Guid("cc0a6c41-2cce-498c-bc3d-7d755c382ba8"), "a card", "card 1", "Text" },
                    { new Guid("cc58e556-0635-4dcd-a0fb-0249ac010922"), "a card", "card 1", "Text" },
                    { new Guid("cc58f68d-a8a9-4813-89e7-be656c2dafe5"), "a card", "card 1", "Text" },
                    { new Guid("cc80009e-97cd-4249-81e6-706fc5fc6400"), "a card", "card 1", "Text" },
                    { new Guid("cca11b45-6a6c-46e1-850a-b68dd9bac451"), "a card", "card 1", "Text" },
                    { new Guid("ccbd05bc-caa2-452f-a9c2-5323f04371da"), "a card", "card 1", "Text" },
                    { new Guid("ccf30e69-18de-4955-8b60-cb142d7ae643"), "a card", "card 1", "Text" },
                    { new Guid("cd065059-d8eb-4ced-ab3d-f79673672665"), "a card", "card 1", "Text" },
                    { new Guid("cdb86843-7b2c-4c51-91b5-cd5f1063ff44"), "a card", "card 1", "Text" },
                    { new Guid("cdc45069-7bc4-4668-9b18-0e94487a91f1"), "a card", "card 1", "Text" },
                    { new Guid("cdc4a4df-68bb-4c60-9322-420b845948dd"), "a card", "card 1", "Text" },
                    { new Guid("ce65cc3a-da64-414b-858d-9f9da337a2c6"), "a card", "card 1", "Text" },
                    { new Guid("ce72bd5c-5ebd-4572-854d-71154b9bb4cb"), "a card", "card 1", "Text" },
                    { new Guid("ceab774f-3f7b-4915-8a82-d58759954a59"), "a card", "card 1", "Text" },
                    { new Guid("cecb1b58-aa8f-421f-916e-3f22d45b9f3d"), "a card", "card 1", "Text" },
                    { new Guid("cefa841f-dd44-495a-a53e-e5f46856d146"), "a card", "card 1", "Text" },
                    { new Guid("cf352cad-b490-42ab-bd76-324d65648e1e"), "a card", "card 1", "Text" },
                    { new Guid("cf37143a-e4bf-4e2a-b11f-ca92774e1705"), "a card", "card 1", "Text" },
                    { new Guid("cf891373-3ab4-475b-ae74-0fce4f10902a"), "a card", "card 1", "Text" },
                    { new Guid("cfac39a9-7fea-4a20-9528-af61f8d9423c"), "a card", "card 1", "Text" },
                    { new Guid("cfd1840d-24e5-45c4-8a71-4ff0b57aaed7"), "a card", "card 1", "Text" },
                    { new Guid("cfe4b97b-9b6b-4081-9efb-ce639ec5e052"), "a card", "card 1", "Text" },
                    { new Guid("d0022d7e-29d5-4326-bbaf-f494e578c830"), "a card", "card 1", "Text" },
                    { new Guid("d0130f89-72d5-4a4b-9721-1050f9f303a0"), "a card", "card 1", "Text" },
                    { new Guid("d0320ff5-4847-4a98-bb77-f78a63f5a092"), "a card", "card 1", "Text" },
                    { new Guid("d0713001-844b-4a1b-b37e-fdbfeb15d7c6"), "a card", "card 1", "Text" },
                    { new Guid("d085e945-8d09-40e8-a0cd-f84e6eee7697"), "a card", "card 1", "Text" },
                    { new Guid("d0e0f5dc-a660-42f5-b90c-652e7b997f6f"), "a card", "card 1", "Text" },
                    { new Guid("d0e99765-dd25-4076-b6a9-8ffd86f45cdb"), "a card", "card 1", "Text" },
                    { new Guid("d152f9ca-aab2-481f-aaf6-cc94d3ff69ec"), "a card", "card 1", "Text" },
                    { new Guid("d161e22c-18ad-49dc-9d44-3290ba801b2e"), "a card", "card 1", "Text" },
                    { new Guid("d1e35a0d-fa19-471c-97c4-3466e7e7b7f1"), "a card", "card 1", "Text" },
                    { new Guid("d1ebaa5d-9920-4904-b530-a7b7c0268e04"), "a card", "card 1", "Text" },
                    { new Guid("d25067a6-899a-4120-80fb-b6bb62c2bbc4"), "a card", "card 1", "Text" },
                    { new Guid("d2ab3b43-b480-4962-927e-dbf808fc7d64"), "a card", "card 1", "Text" },
                    { new Guid("d2caabe3-3a06-43eb-af55-e561aef0cd7d"), "a card", "card 1", "Text" },
                    { new Guid("d3356aa1-8b12-46d6-b66b-ae9094dcd5c5"), "a card", "card 1", "Text" },
                    { new Guid("d37dbe92-d02b-4e53-a111-6a3f631b3d7d"), "a card", "card 1", "Text" },
                    { new Guid("d3dfe31b-89a7-404f-a368-dd6e065a95c0"), "a card", "card 1", "Text" },
                    { new Guid("d3ff5d98-52d6-42d0-916c-42928b762760"), "a card", "card 1", "Text" },
                    { new Guid("d4c98c5c-5d9d-4d65-b1bd-71e9100d173e"), "a card", "card 1", "Text" },
                    { new Guid("d4e0dfc3-1fa8-4ad5-865c-4c6c2874f33a"), "a card", "card 1", "Text" },
                    { new Guid("d53bc884-71b7-41fa-a49a-5eb68765ef86"), "a card", "card 1", "Text" },
                    { new Guid("d53de047-c510-4dfc-aa18-3c864af3bf98"), "a card", "card 1", "Text" },
                    { new Guid("d54cd6ea-6406-4748-8b5e-623e1d4047cc"), "a card", "card 1", "Text" },
                    { new Guid("d5e9acfb-b921-490a-a941-f4ed4a4bca0d"), "a card", "card 1", "Text" },
                    { new Guid("d5f3faaf-329b-4748-9c14-5fc344493d22"), "a card", "card 1", "Text" },
                    { new Guid("d63ae33a-a549-435b-908f-47cab9dc8c3b"), "a card", "card 1", "Text" },
                    { new Guid("d6950dce-537f-4efc-ab1f-0b047113bdfc"), "a card", "card 1", "Text" },
                    { new Guid("d697dc66-9524-44da-957a-83f7e9c8a328"), "a card", "card 1", "Text" },
                    { new Guid("d74d1ff2-bd90-493b-bef4-7c9353b1a48c"), "a card", "card 1", "Text" },
                    { new Guid("d7731a0c-3658-4aeb-9c1b-e316a00c56f7"), "a card", "card 1", "Text" },
                    { new Guid("d7e91d59-de90-4d83-b21b-48e4cc09a1e1"), "a card", "card 1", "Text" },
                    { new Guid("d87de3cb-9aeb-4499-970a-e6c43a7f94eb"), "a card", "card 1", "Text" },
                    { new Guid("d8d605ae-4223-41cb-ad72-37fda9ff1e73"), "a card", "card 1", "Text" },
                    { new Guid("d9be0ce9-6894-450f-a530-c28b95c3adb2"), "a card", "card 1", "Text" },
                    { new Guid("d9ef49be-1889-4b41-8ee5-abc892723263"), "a card", "card 1", "Text" },
                    { new Guid("da1b2876-8234-4235-b3e6-b4f9518981a0"), "a card", "card 1", "Text" },
                    { new Guid("dac87581-c85e-47c8-94eb-9e2f1e50cbe6"), "a card", "card 1", "Text" },
                    { new Guid("dafd9f40-11d7-45ba-a8c8-8d0b0bba8999"), "a card", "card 1", "Text" },
                    { new Guid("db4e0f1e-aaee-46c0-b7f3-0cfa41cfacac"), "a card", "card 1", "Text" },
                    { new Guid("db5e6085-5cfb-487b-923d-2cacd4b672c0"), "a card", "card 1", "Text" },
                    { new Guid("dba54bfe-5a57-41f8-9ef6-7025b131502c"), "a card", "card 1", "Text" },
                    { new Guid("dbacded7-d4ee-4352-a057-edfe21340a11"), "a card", "card 1", "Text" },
                    { new Guid("dbbf72e7-ae28-4cbc-831e-9e31bfbde36a"), "a card", "card 1", "Text" },
                    { new Guid("dbc5414d-fd92-4bb0-95f7-2bff9dc22a46"), "a card", "card 1", "Text" },
                    { new Guid("dbe6db13-8dfe-435d-9495-94675b8bc636"), "a card", "card 1", "Text" },
                    { new Guid("dbfbc50a-0537-4853-a684-60ee4c2a6211"), "a card", "card 1", "Text" },
                    { new Guid("dd2c5590-d51d-4ee2-b486-c7b5d5f18299"), "a card", "card 1", "Text" },
                    { new Guid("dd38a982-a39a-4f64-a419-d4fe93406475"), "a card", "card 1", "Text" },
                    { new Guid("dd423f35-e8a1-41ce-82f4-df62f432c4cc"), "a card", "card 1", "Text" },
                    { new Guid("ddc4132a-95a3-4fba-8321-abc3e19c1d8a"), "a card", "card 1", "Text" },
                    { new Guid("de5938ff-b562-4cb0-9afe-071ee689990d"), "a card", "card 1", "Text" },
                    { new Guid("de85105e-5157-462d-95db-962f7f2fea56"), "a card", "card 1", "Text" },
                    { new Guid("de966a52-4d8d-48a0-ac6e-e66790c939e6"), "a card", "card 1", "Text" },
                    { new Guid("dea3e11c-702e-40ee-86a0-742fa6cd757f"), "a card", "card 1", "Text" },
                    { new Guid("df44200f-6f98-4e2e-aedd-92dbc047cfbf"), "a card", "card 1", "Text" },
                    { new Guid("df44a4dd-9cf4-4910-bcbe-f6df92615dfd"), "a card", "card 1", "Text" },
                    { new Guid("df4dd0a3-7d5b-4338-9230-a796362fa3c9"), "a card", "card 1", "Text" },
                    { new Guid("df68cb71-c5e5-4449-ae2e-a61d39bc5339"), "a card", "card 1", "Text" },
                    { new Guid("dfc491cb-76d7-4d17-aeb2-33584076b019"), "a card", "card 1", "Text" },
                    { new Guid("e0085a28-6264-4efd-bab3-0224bb1cba4a"), "a card", "card 1", "Text" },
                    { new Guid("e013d6f0-2abd-4014-864d-b7a8d2f96b27"), "a card", "card 1", "Text" },
                    { new Guid("e01e157a-fb8d-46e4-accc-4c713c43cb2f"), "a card", "card 1", "Text" },
                    { new Guid("e027baee-beb9-47ae-9a98-4b8f97c81d5e"), "a card", "card 1", "Text" },
                    { new Guid("e02ddd9d-c93a-4bd3-9d53-41fec962720a"), "a card", "card 1", "Text" },
                    { new Guid("e0543b31-c20b-4902-aa40-8d0c67a19ce3"), "a card", "card 1", "Text" },
                    { new Guid("e0fcac3f-9400-43d4-a88d-0d30ef2b4a81"), "a card", "card 1", "Text" },
                    { new Guid("e1550ec3-86fb-4552-ad1b-40d984aa6c5e"), "a card", "card 1", "Text" },
                    { new Guid("e17a0f3d-531f-4663-b0f0-5ce662127531"), "a card", "card 1", "Text" },
                    { new Guid("e20291d3-d6d6-489c-8490-4ab74a64fe9f"), "a card", "card 1", "Text" },
                    { new Guid("e2094a3c-2ffd-4a75-bf2b-a0d3ffc109d9"), "a card", "card 1", "Text" },
                    { new Guid("e2513a9f-efbc-4bb5-87fe-32b65b74c9bf"), "a card", "card 1", "Text" },
                    { new Guid("e2aa5f55-3511-4417-bdff-5d8cb1dfbff6"), "a card", "card 1", "Text" },
                    { new Guid("e2e4916c-4dd0-4893-9f9d-8f0c987a65d7"), "a card", "card 1", "Text" },
                    { new Guid("e3163ea5-5abe-4ef5-84b1-52daf52d15a5"), "a card", "card 1", "Text" },
                    { new Guid("e34ff98d-4e40-47b4-b321-4445b0759a14"), "a card", "card 1", "Text" },
                    { new Guid("e3547776-b9a2-4f32-80f9-e555c8fe0d33"), "a card", "card 1", "Text" },
                    { new Guid("e3e6492c-5d7f-4cb9-bbd6-880c48a22a50"), "a card", "card 1", "Text" },
                    { new Guid("e406e4cd-fcff-4db7-ac0a-10714209f10e"), "a card", "card 1", "Text" },
                    { new Guid("e4630765-d165-44de-b68a-18a90a332a7e"), "a card", "card 1", "Text" },
                    { new Guid("e4814233-36cc-4b2c-8a66-4eb948c67798"), "a card", "card 1", "Text" },
                    { new Guid("e4f9c81c-0127-4dd1-a36e-92c1077b61aa"), "a card", "card 1", "Text" },
                    { new Guid("e523ec00-f861-441c-80d1-d15030436354"), "a card", "card 1", "Text" },
                    { new Guid("e5677328-b79a-44d9-bceb-7b1c61fe46ff"), "a card", "card 1", "Text" },
                    { new Guid("e569705d-4bac-4361-9943-471c0e70d856"), "a card", "card 1", "Text" },
                    { new Guid("e5a49165-8357-4c6f-869f-fb30b2f806cc"), "a card", "card 1", "Text" },
                    { new Guid("e5d754f3-e083-4504-887d-da68f0f3e7f0"), "a card", "card 1", "Text" },
                    { new Guid("e620c0e3-1310-48d6-b356-8bcdbe9426ab"), "a card", "card 1", "Text" },
                    { new Guid("e624e813-8a89-4a71-81d8-da11ad4d1223"), "a card", "card 1", "Text" },
                    { new Guid("e6305b7c-7515-4b7a-8680-c49305b1b0f3"), "a card", "card 1", "Text" },
                    { new Guid("e6769d57-1d00-4ad5-9902-754b507d043d"), "a card", "card 1", "Text" },
                    { new Guid("e737526b-e0a9-4ef9-8098-19afb7626012"), "a card", "card 1", "Text" },
                    { new Guid("e7b88047-6095-4183-8dce-bea96a83531d"), "a card", "card 1", "Text" },
                    { new Guid("e7d65d6d-c756-4e2c-b34c-4b5d0ac2e6df"), "a card", "card 1", "Text" },
                    { new Guid("e83096ec-b225-4f34-a65f-1ff1a09c1936"), "a card", "card 1", "Text" },
                    { new Guid("e85c68ec-ce4a-4da9-a8ab-05ac3852fa57"), "a card", "card 1", "Text" },
                    { new Guid("e89bb1ce-f01a-46ef-bc08-cdffe5c7304e"), "a card", "card 1", "Text" },
                    { new Guid("e8ec665d-a5ab-459f-899b-0a510ad08ebb"), "a card", "card 1", "Text" },
                    { new Guid("e8f27ee4-f488-4aa3-9ca8-e40e1006d042"), "a card", "card 1", "Text" },
                    { new Guid("e92f39c8-e1c0-498f-906a-ce205288aa21"), "a card", "card 1", "Text" },
                    { new Guid("e93b3a03-7d69-44a6-8e6e-56c29e4385ef"), "a card", "card 1", "Text" },
                    { new Guid("e9a0362f-457b-4d82-b39a-1dd311e9d789"), "a card", "card 1", "Text" },
                    { new Guid("e9b06d76-79c7-4681-afb9-db1610d55149"), "a card", "card 1", "Text" },
                    { new Guid("e9f8f68c-d38f-442a-a415-1c05295ba6c8"), "a card", "card 1", "Text" },
                    { new Guid("ea8054b3-21f3-4761-8bc2-4ec66661a39e"), "a card", "card 1", "Text" },
                    { new Guid("ea87b623-72c7-4ebe-8799-b174f0abfac3"), "a card", "card 1", "Text" },
                    { new Guid("eae7e990-e5d7-47fc-abd3-eb19386c05c0"), "a card", "card 1", "Text" },
                    { new Guid("eaeadc27-d5df-4033-8809-161e12ee2cbc"), "a card", "card 1", "Text" },
                    { new Guid("eb4b4707-14a6-40c6-a66a-97973b1c27a4"), "a card", "card 1", "Text" },
                    { new Guid("eb6d601e-f9f3-49fc-84ff-c6d5da1a55f2"), "a card", "card 1", "Text" },
                    { new Guid("eb8f92d7-4053-4a0f-b526-2cbbf356b6f3"), "a card", "card 1", "Text" },
                    { new Guid("eba02f1c-044b-4e96-b9c6-d1336250264f"), "a card", "card 1", "Text" },
                    { new Guid("ebe9ed89-d3af-4adf-80a1-270f7c2ed7c5"), "a card", "card 1", "Text" },
                    { new Guid("ec42a235-e76c-4cf8-84ee-6d5f8aa8f7b1"), "a card", "card 1", "Text" },
                    { new Guid("eccf1e95-8b0d-46a5-8550-a83478de0cb3"), "a card", "card 1", "Text" },
                    { new Guid("ed46505f-fd6e-406a-8cef-03867b336cbc"), "a card", "card 1", "Text" },
                    { new Guid("edadb9d7-7cd5-4728-84c3-ed13b18f6413"), "a card", "card 1", "Text" },
                    { new Guid("edf405cc-9dd2-4b29-a9e9-f7c47a7e3cfb"), "a card", "card 1", "Text" },
                    { new Guid("ee02a773-4532-482e-a1a1-6a17fc68fe4b"), "a card", "card 1", "Text" },
                    { new Guid("ee4e72e1-bb55-4fef-bf8f-cb5f220c85ec"), "a card", "card 1", "Text" },
                    { new Guid("eecdab87-cce4-448c-9f1d-7406ae4c6c96"), "a card", "card 1", "Text" },
                    { new Guid("eee1cd98-253e-4cc0-bb7f-abd0759eaaa9"), "a card", "card 1", "Text" },
                    { new Guid("eee8da13-dc9b-4a49-bf57-836e589f810d"), "a card", "card 1", "Text" },
                    { new Guid("ef843dca-92f7-400f-a036-385b61a2c5f0"), "a card", "card 1", "Text" },
                    { new Guid("efb34836-35f7-4127-8e00-7acdd9244e91"), "a card", "card 1", "Text" },
                    { new Guid("efbf03df-f90b-4cd5-aa11-695fff827dac"), "a card", "card 1", "Text" },
                    { new Guid("effd06f9-7bc4-4eb4-b133-717aa2ad410d"), "a card", "card 1", "Text" },
                    { new Guid("f0cbea2f-17da-4645-afb7-0dcf48c10959"), "a card", "card 1", "Text" },
                    { new Guid("f164853b-1431-4d68-a0fa-a34af730cbe5"), "a card", "card 1", "Text" },
                    { new Guid("f1a7230b-2acc-4bf0-99ed-b3556c1e0353"), "a card", "card 1", "Text" },
                    { new Guid("f1bd9f45-1a7a-41b1-8d79-3f8ade4eded3"), "a card", "card 1", "Text" },
                    { new Guid("f264b40a-caa2-4d7d-928c-06b5b24c5575"), "a card", "card 1", "Text" },
                    { new Guid("f2b511b8-06ed-4f15-b7e6-6ebe676b2788"), "a card", "card 1", "Text" },
                    { new Guid("f2f0afe3-2e8a-417e-9a4d-70eb8d9baf73"), "a card", "card 1", "Text" },
                    { new Guid("f2f4a526-ad68-4822-9cc8-3aa2019af702"), "a card", "card 1", "Text" },
                    { new Guid("f2fd129d-1917-41d1-b448-7198cb671586"), "a card", "card 1", "Text" },
                    { new Guid("f302607b-4736-42ac-842f-0ac48a3a91dd"), "a card", "card 1", "Text" },
                    { new Guid("f3336c3a-2a2a-4b2f-97cf-d498f807400d"), "a card", "card 1", "Text" },
                    { new Guid("f333cb7b-e3bd-4b56-8424-14217169875c"), "a card", "card 1", "Text" },
                    { new Guid("f3e5332a-4465-4f5c-933d-208c355579f8"), "a card", "card 1", "Text" },
                    { new Guid("f40241a4-ba33-488d-8955-7f5ba278a50b"), "a card", "card 1", "Text" },
                    { new Guid("f46afbce-a8b8-4064-a159-c3e56dccaba5"), "a card", "card 1", "Text" },
                    { new Guid("f4ab5bd9-4ded-4c67-aae3-17b728ab96e7"), "a card", "card 1", "Text" },
                    { new Guid("f4b63a13-bd13-4a86-8d4e-18a9617c3bbc"), "a card", "card 1", "Text" },
                    { new Guid("f5340c14-50c9-4912-b905-a0cbfb3b6147"), "a card", "card 1", "Text" },
                    { new Guid("f5366014-1dd0-428f-bff2-ea02959059c1"), "a card", "card 1", "Text" },
                    { new Guid("f6060f3c-f0d4-4cb3-8caf-bb8d5477ecf2"), "a card", "card 1", "Text" },
                    { new Guid("f61c779b-5324-4952-8784-3dfc4de22171"), "a card", "card 1", "Text" },
                    { new Guid("f61e51ab-ec49-4e27-bb11-ad942d326743"), "a card", "card 1", "Text" },
                    { new Guid("f634cee7-3bbd-4ac7-b88e-d785d6466689"), "a card", "card 1", "Text" },
                    { new Guid("f67f370e-ee2d-45d3-8ae6-66ffb74feffc"), "a card", "card 1", "Text" },
                    { new Guid("f68cedd2-d336-4519-a9aa-5ab6746681dc"), "a card", "card 1", "Text" },
                    { new Guid("f6acf171-9df0-4dbe-87da-72a278c39599"), "a card", "card 1", "Text" },
                    { new Guid("f70a5b52-9d02-4339-b0a2-428ff9d43d7b"), "a card", "card 1", "Text" },
                    { new Guid("f71c5650-2ea7-480a-b11a-bbc67898bbdc"), "a card", "card 1", "Text" },
                    { new Guid("f7688d1b-c14f-4870-b70d-85ff1890af3c"), "a card", "card 1", "Text" },
                    { new Guid("f7985ef1-8f75-4676-9c7c-c450f40d6b8e"), "a card", "card 1", "Text" },
                    { new Guid("f7a20169-f74f-4e63-a9b1-2d232477a285"), "a card", "card 1", "Text" },
                    { new Guid("f7be29dc-d209-4f35-b72d-cfc252b7751f"), "a card", "card 1", "Text" },
                    { new Guid("f7cbc282-6bf6-4f58-9870-4c1f71ae5375"), "a card", "card 1", "Text" },
                    { new Guid("f7d0c1cf-1e93-4c4f-ad5c-f5ee08b050c7"), "a card", "card 1", "Text" },
                    { new Guid("f7d4e11e-44d2-4ab9-9b54-babbe93f8c80"), "a card", "card 1", "Text" },
                    { new Guid("f7eff086-dec8-40e1-9b55-472c06a4c75a"), "a card", "card 1", "Text" },
                    { new Guid("f80c5372-3e84-4b94-8f4a-36287889c99f"), "a card", "card 1", "Text" },
                    { new Guid("f86cfac9-eba1-4b80-b6f1-0647274b8a7f"), "a card", "card 1", "Text" },
                    { new Guid("f9531cd7-31fe-479b-a7b2-454bff71bab8"), "a card", "card 1", "Text" },
                    { new Guid("f9dfa0ca-b73c-4165-8592-4e9b1422069a"), "a card", "card 1", "Text" },
                    { new Guid("fa359387-3a21-41e0-9f3a-93a331937de9"), "a card", "card 1", "Text" },
                    { new Guid("fa806119-30b4-400d-b073-085d277a4588"), "a card", "card 1", "Text" },
                    { new Guid("fada7ba2-b24c-425e-b4d2-ae106282909d"), "a card", "card 1", "Text" },
                    { new Guid("fae60ab3-29f3-41d4-8fe0-0533edccf699"), "a card", "card 1", "Text" },
                    { new Guid("fb13b0ed-f144-4ce5-a7d6-89a9935a160f"), "a card", "card 1", "Text" },
                    { new Guid("fb3c62ae-60e9-4ed9-bf59-7d3c0897bc03"), "a card", "card 1", "Text" },
                    { new Guid("fbc55d20-e576-42de-81cc-385431d44bbe"), "a card", "card 1", "Text" },
                    { new Guid("fbe6b7ea-d5dd-4d8c-ae47-54cb8354ee9c"), "a card", "card 1", "Text" },
                    { new Guid("fcb58345-3d95-4141-9d99-fca6529e2f0e"), "a card", "card 1", "Text" },
                    { new Guid("fcdb094f-be05-43e8-b157-24348a76dcff"), "a card", "card 1", "Text" },
                    { new Guid("fd7971eb-6c9f-47d7-85ff-70a24c3f3508"), "a card", "card 1", "Text" },
                    { new Guid("fd867a26-838b-4624-9b1d-5dc092648d50"), "a card", "card 1", "Text" },
                    { new Guid("fe93d883-875b-4473-a356-63143cc8c813"), "a card", "card 1", "Text" },
                    { new Guid("ff01297c-1707-4095-8ba5-fea60c94c9f6"), "a card", "card 1", "Text" },
                    { new Guid("ff256dd5-c844-4a91-9eca-eeb21f2481e7"), "a card", "card 1", "Text" },
                    { new Guid("ffc3577d-19a5-48e5-ba4c-a0b4954e9d32"), "a card", "card 1", "Text" },
                    { new Guid("ffe89394-632f-4916-886c-7b878a50ed5e"), "a card", "card 1", "Text" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("004ad516-4f5e-4db8-93d9-2e6847e0ae49"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0079423b-8858-4fe4-be99-349cee88783b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("00d37f0e-0841-4eea-9d4e-b710793c651c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("01675a28-e993-4d99-8175-ef013c5cdb7a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("01876b0b-d3a8-4b95-8afb-8896a2bd8e39"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0194b09a-8616-48b7-8618-f250b29cfe12"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("01c57a1f-8988-4806-a167-a7c38fde80ea"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("01c6f0d6-c6e2-4d86-a599-a59aaf4c5359"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("020b1d4a-1947-44a2-a448-8145dd194d2e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("02501554-9916-4482-95ef-b291e34a8473"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0279dfc7-b8a4-4406-a1a2-f1a652e47385"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("02b890ad-d7e4-4b3f-a55a-2db288da02ea"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("02c0c352-4095-4366-8740-41a030ee178d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("02c72e9f-83ee-4c91-9ff6-b9806edb6f77"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("03198661-1fad-4f90-858f-1200218fe228"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("035cb57e-a91e-472c-8661-25a5c9521927"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("03692c42-8da4-4826-b882-58611be291d2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("036c8c4c-8462-400c-8544-6774875baea2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0392dafc-a90e-45bd-9873-2770acdfc79c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("03cb69ca-9c8a-42b3-bfd6-78d33ce9acbd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("03df1434-4e16-4dc7-bcb1-8219b27fa845"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("046f86f4-51b9-4c47-96c2-592f1f34c35f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("047cd526-d1b6-4e2b-a346-f14c5e44e3de"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("04825d22-82fd-4b3c-a04e-08017e733d7f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("04913335-1c97-4f97-9cea-8c60cc45b160"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("04b978e4-6c00-4e0e-b893-bdabe7d29fcc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("04d4b2cc-50a5-4e07-bf3a-d88363ac8e9d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("04fc507b-1d0c-4270-b1a3-01986685c3cc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("062da6a9-e4de-4f6e-9133-3e3b01f11195"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("06388984-c9a7-4e66-b8df-590aefeebeaa"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("068bee53-9846-4c19-a6e5-c5c267e55e73"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("06dd708c-0640-44da-9eb7-a83b35aa3bc1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0795a864-0e22-45e9-9824-c2e056163694"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("07c9597d-733d-4c1f-8c55-67cc8f10034b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("07d0b6b8-0eaf-4081-928f-87803f01ca05"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("07d1ee41-df94-4852-b287-395d59df57ae"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("07fad4a5-9ce7-4e75-be0d-a541bc85d69f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("081b2e3a-2ec7-43c2-b48f-f5c9923068b3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("08454d16-ea94-4665-a6eb-e9b6b2f88d50"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("08603a5e-04cc-4f6d-a89e-dd3e6fa5b42c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("094b51a3-83ae-4b8f-b279-4095a606f423"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("097ac624-9151-4c5e-a3c6-fd511a52b137"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0a1179a5-91b1-4b37-a35b-80e60f726efd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0a8e96f0-1dd7-4118-9482-3e375c088113"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0aa31bc2-f345-4a87-ad6b-a675dddbf81b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0b444900-5bbd-473d-ae8f-3a080f79ffb0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0ba09003-d726-44ac-8ff6-068d615fe648"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0ba0b1a2-f0e4-46c7-b06d-108c2980085a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0bd9891c-74e7-4cc8-a3e4-4ac19eff3153"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0c019b7a-76ae-43ef-b546-6a51e2ec8ad8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0c1e49c4-a8c9-4692-af0d-60784121c03c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0c684ee4-5f34-4b43-bede-10ff8aea2be7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0cd8b3e5-a3ad-414c-960b-d96e56cf7f70"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0cda6a89-1d19-47b4-9bb5-1587384c4741"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0d02ee21-d23a-4fff-ae18-e61710a8d936"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0d3f5bca-19c4-4c50-a2c7-fe6a47bfd82c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0dcdb15b-dd7c-4b29-9071-d89925b91d3b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0e1d69fa-07f8-4a28-80f6-59743f923621"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0ee4ede0-9871-42be-9e33-335c8f145edb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0ee9e86a-1eac-41c5-b167-947b2906014d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0f09255c-d04d-4f41-aef3-1b844bd9b311"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0f23299c-b8b3-4d01-9050-6c9fc10779f6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0f3dddf8-89d5-45f5-a2c8-37a86aa5fce3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0fea0d39-560a-4e9b-a96a-af7d541937fe"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("0ff17f5d-2597-4f56-8b44-4f7d09eef03e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("10026a51-b141-4d82-a6a0-681f27812cd9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("10075b84-ab0c-4530-8982-e596a8802601"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("102a7e36-b599-4960-b102-d7cde2688aac"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("10ecca34-b54e-497c-aacd-78d04870e5d6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("10fc79f4-7368-4b9c-b9ac-5ad12381c489"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1173a0bd-45bc-4140-b46b-f93b7d190bd9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("117464c0-8f45-4853-9e22-e3d61bd99ae2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("11bd8205-cfcf-4409-b065-c4f073915dd6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("11fb06c8-9913-49b2-b134-4d2677fb84e9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("121dde4a-c207-4fa8-ae3f-a0f668a058b1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1246224e-e090-4076-82e2-be4d2483a776"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("12ca5c6a-432e-4b2d-955e-376e2c30fe4d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1303aa48-172e-4df6-aa1e-abebe58a5929"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("13d81e01-bfd6-49a1-ae8a-1b84baf09ff3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("14791848-4b22-46d8-8263-b2cca8610754"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("149afa6c-2464-4208-8c08-ba5332217fa8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("14a65b6d-2bb5-49fa-a2bc-a097bb26939e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("15184afb-3169-46a8-90fa-c53590cfd15b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("15266539-bce3-4841-9563-33f584fa85dd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("155ee89d-2837-48e5-9c9b-0d4554f69f46"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("15770b8d-fec3-4ce0-bbfb-2027e4a20824"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("158fad7a-33c1-4f40-94d4-1478c3586003"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("160195ad-8130-4e2e-8bbc-8e83ec74632b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("161cfa35-656d-4bfd-82f8-375b29972853"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("162b43f6-1a00-4ea4-b8ef-6951e7baad2f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1694b525-c377-4342-8bce-bd918bdea2b5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("16b023e9-1366-4ee1-913f-0f588a86568c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("16e54429-ccad-4483-a6f7-54c6d3ce2baa"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("176e5af7-5de2-4412-887d-ce14202bb686"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1772bb16-75da-4936-9446-8485e2432fad"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("17a27437-e65c-459d-8845-d3e6659b0f95"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("17bc3eab-7c12-4156-b6eb-a12daa6fec57"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("18114e6a-4778-45c5-8cf9-f294f3f709d7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1827f7b1-fc69-42ed-ac15-b375f7e1a039"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("183889aa-750e-483a-a79a-1b076d012481"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("18d2c0f8-574f-41dd-8e22-d852c1d2daa6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("18d577af-e54b-4154-90e0-90ed3bb986d1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("190c48a4-1f5d-4670-9932-1a4188726559"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("190c7283-c6d3-40dc-a150-35614ba88202"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("19914501-de9f-4103-bab5-7ef87ee019ec"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("19993a42-3869-4633-8a05-69c22db7aa77"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("19e3bc31-fffe-4bd0-89f3-2f051b4b3d7a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("19eab34d-da23-4bc9-8ff2-f42fe7ea1db2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1a228ff9-3e17-4ac7-87b4-d45293374682"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1a4a2ece-cf37-449b-bb3c-21130d7720db"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1a7eaa3b-a06f-4939-baa3-84646a5d1f0a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1bdff7dc-d0aa-4aba-808a-2f2b876f81a1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1bf30209-368a-41e3-b5f1-605fd1172cb3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1c3208ae-9735-44fe-9824-3e378ce787be"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1c3903f3-4915-4062-8c58-5afc47e1f270"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1c396ddf-d083-4dfb-8739-0766670db582"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1ca260d1-b792-4a73-bc8f-8a4c83d5656b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1cb499b3-6435-4f20-bc58-c9408c63dea3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1cf450f0-9ffb-4ebf-b497-94dfef4bd3cd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1d4315a8-3a56-41f9-b52b-79f5b09d5d08"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1d44a558-3621-477a-9426-b9f11453937a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1da55a00-2098-4e5b-8e48-575c5b22aa1c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1dcbb29c-6fd2-4843-927e-d582524eec4a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1e50b8ea-a2c8-4322-b86d-0112e029666a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1e66fec2-d0de-4d91-b79b-3829ce70af08"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1e8770a1-efae-4ec1-85f4-27d1e8d50a58"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1eae6e87-bd51-4b7a-b09d-fc9c86f6ad6a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1ec92ba2-c1b4-4403-b07a-d20f7395b4db"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1ed4f506-6101-40b3-b80e-6a0c13ee580e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1f00e22b-694b-4a0d-8e3c-8644ebc9ef99"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1f47100b-3b5b-4f7f-bec6-eaa30b5880b0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("1fb5541f-684c-4806-bcd9-3a8b1f86e38c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("204ff690-6278-43b0-aad5-eb702e2fd870"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("20849939-0c44-4a23-92e8-e7ce5417896d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("20a0d452-01ce-456a-a311-f3e28674e8ed"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("20d41623-a4d7-4449-9fcd-b013ab1e8eca"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("20e3ef1d-7fee-414d-8e48-9861002604af"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("21405bc0-6d45-44af-b13b-e92fdc56ad87"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2169f33a-7c41-45c5-a59e-7c6f2dc2740b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2185acb6-9fa8-4093-a471-b643711ae295"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("218d3ca2-7034-47c3-a5a6-9f5b5933eee9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("21937e9e-a548-4ca7-9bea-e56601d7d20b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("221c9314-3b10-4c7b-b0a3-c1d9be7d44e4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2297bc62-7f78-4d0a-b211-dfc3ba331551"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("22afb229-091d-4bcf-8157-5ce2766ec359"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("22d7bf80-b86a-4651-b2e5-c0c7edc6a496"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("234ddbef-01db-409c-aec6-87d75df395d4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("238a4371-1696-47ca-ae55-a32941cac044"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("23983ad4-d207-45aa-8df8-feaf11e0e6a1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("23a655e3-faa4-42f0-8112-340fa9fc1add"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("23ac6aa8-4ef3-4881-b4b2-52094c03c88f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("23b87e3e-4cb3-4570-9913-e8dccdf767c4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("241db16f-f928-4315-a3f0-49db3ac8a4af"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("245554c2-4dd3-43e7-a389-8adedc42562a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("24948e74-dfa0-483e-8ae3-591559a7b00d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("251f0e74-0691-4f15-b4a8-8b929c532b8b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("259fd064-5ed1-4bf2-8a12-c466b3bb1858"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("25fe672f-c23b-4fbb-bf40-c7993f1bf4cf"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("262d297f-aca1-42f5-bef0-128ce3204589"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("263f1410-52da-4096-bcdd-b500060c6f26"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2640e795-aa46-4403-86ea-4d2e98966143"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2732d814-edac-4e1e-ad05-a32dab1fae39"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("273e6c5b-ca7f-4315-83a2-9fa9c9085e08"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2762513c-3219-441a-9f57-be21d76faf57"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("27797916-b891-450a-b207-eecac0c24c65"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("27941be6-34ad-4500-aaab-a6e971d7fe08"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("27df3d63-2f0d-4c3b-8e7b-68a67e405024"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("28aaa9ca-eef3-4ae4-8869-69636c54a293"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("28cbae45-aaac-45a8-98a8-884a98d02c9a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("299fce64-82fb-4a36-a00c-0385cb019ff4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("29bdc81d-4b60-4fb0-802c-06afdc08015a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2a31b362-f406-4c91-b443-c488f12dc5cf"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2a9b1bd9-d0d4-49d0-b8a6-ada3e77b0de8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2ad48329-b802-491d-bbaf-b0c3dc0107f3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2ae39b83-f21d-4af7-9587-7456e39cec44"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2b0b2b0c-0837-433f-8206-e2995112074f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2b5e8ef6-9c70-4fba-82cc-026d264ebe13"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2bb43e55-b362-4d82-a0d7-458427451007"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2bb7e93e-b1e4-4c6c-a76e-1200dfdd75d6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2c45c303-8420-4f48-90ed-5685a69b419b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2c75282f-89d6-492d-ac41-c86ae6ec7f59"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2cace7bf-d772-4309-bf8a-c50dd357d7d5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2d1f47ff-41a4-4ae7-ba10-b08cae07cdaf"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2d4cae15-744b-4541-bed9-91478b7ce296"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2d80bfc4-3bc7-4e16-aaf5-a6536f954197"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2da131fd-4ca4-4903-b12f-b7acc18d51ca"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2e34280c-c8b3-4177-8dc5-ee0013bfcf15"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2eda07f1-9a07-4047-875e-10a256dae0c6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2f91cb04-4c4c-4575-9bb9-8029da2b1e49"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2fc0a22c-d50e-4284-8fb5-dbbdcc42d2e8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("2ffcf48c-b035-49c5-b8d6-b203950d0afb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3034c93c-19e0-4515-b710-e2b2cb733af2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3043a5c4-0118-42e6-b301-0656814af312"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("306061f0-7005-4dca-a426-7d38cde5af32"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3101d28e-9002-402f-a1f5-4c2f03784c1f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("31274403-db48-4c6b-b1fa-4f8e7d49222d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("314d22ca-622d-4af4-bf3a-a8b05cd785af"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("316a5261-2dfc-4638-b811-8dd7ed29df89"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("31d6c8bc-abde-4ea5-9731-21bad561e811"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3218e3e1-30e9-4cb0-8c3e-b3af6c99237b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3226fc10-e965-41df-9ddf-8bb5940f6994"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3245e6af-6b9a-4fd5-8fee-79e4e3c23a6f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("324e065d-4baf-450f-ba05-27024713fe46"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3263db17-df7d-477e-9e3e-3dca179ae2df"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("327b7a89-a1d9-45aa-b557-f72036a1c3cf"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("32a53a42-2a8a-44cf-bc8b-f1bcbc4b10bb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("331e199d-b364-40f1-a1b9-c862c146626a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("336a4341-e15f-4005-be0e-9982d147ace6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3371b987-85d5-474a-8af3-5b76f2613e25"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("337f2be9-93f3-4585-b773-2bd45f075c20"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("33b4d1b0-00b0-49cb-b9d9-641d4d85f77f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("33ba9084-508a-4790-84a1-c908eff59605"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3496e326-4ddd-42ec-b56d-4ba39707f945"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("34f45ff9-de29-4e54-915e-44e9d7e020dc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("35042847-7b35-483e-93ff-a174f9b0232a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("367f0988-29d0-431d-8332-b8306d4eaccb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("36af8b20-d4a5-495f-806e-2892d2ef0357"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("36f3cc7a-89ef-4ee8-8a1c-f758d99ca8d9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("36f7bcf4-9d05-4a23-b843-0e38cd2feb52"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("370e5b27-4f7a-49a1-87ee-bc9e8f89285b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3723ef9e-0936-4e0f-9746-a8b321d75e9d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("372c07ec-2f99-428a-b4ab-aa5726b10627"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3770c603-4054-48c3-a461-97f050c227eb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("37ec7fdb-e4be-4ade-93c6-6c1dc7b24c67"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("381b4f34-1491-4192-b6b2-a93607a37d89"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("382273fa-c4b5-4758-a7d3-c0f8fbafff76"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("386250d2-88f5-424e-aa37-2d76f4ab7d3f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3890f13e-f361-4ab0-a84c-61af4c6ac45b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("38cf11ca-13e2-4b82-97a3-1b94b4fa68c9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("38e6215c-51fc-46d4-869b-c3deb2a5b73e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("39fed475-c69b-495c-b3f2-bdbcc71be21f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3a7685dd-1e65-43b9-9cc0-0900662be6c0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3b0ab149-f076-4790-81c5-4918e46a09cb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3b3e3e00-7d7a-425a-a6e7-3b67c7c7c3c7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3b716de0-7924-4762-a266-aa0821549543"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3b7d7d0c-0e63-40ff-b64a-c2a83c98221b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3cb85182-b2a2-4f02-848a-d6a5285bdf3c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3cf16096-ed81-42df-ae70-02a6972987c4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3d0e0a16-5f5a-43ad-b083-d9ed89b58f3f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3d2c32db-e22b-407c-98cc-c5cf0141022f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3d365960-a661-4483-b8dd-00ad3177327f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3d77e8b7-664d-4b5d-a05e-28cc46f5d9d7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3dc6e2cf-b842-493b-a604-68030f5951b1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3e46a8a8-d0c6-4308-9513-d51221f71618"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3e60f7a5-0914-45e6-8930-5201d3ae7860"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3ee7a02c-50b2-4f1d-a6c8-2c0a149985fb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3ef99944-83f2-42dd-a818-182c86159eec"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3f17ad83-3eb7-4020-bb82-786260267e70"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3f90504b-e8d9-4b8d-a7a8-7ba9e964fef9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3f97845b-37c4-45f2-8e60-da73e8389e9b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3fbe6b29-6537-424d-9148-77bb27e7fd1c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3ff66463-e2e9-40bd-b625-c7b2e7f3f4dc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3ff6a6a7-b33e-4a33-905e-b3a1c9608e2d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("3ff87b57-62f7-4b99-82fb-13d22012875b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4060c09b-909c-4e2d-a1bb-4551912d40a7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("408f06ed-8435-4669-9bfc-48d123ca172f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("41108311-59de-474c-9ebb-49cd5390947b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("41195bbb-40b6-4eb1-9b6f-f49033e05b37"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4135de31-3ab8-4cdf-a6ad-010adee01056"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("414e0bb8-291d-437d-b94f-d1f28ca2d0cf"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("417cca07-e260-4887-894b-02e634744e18"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("41a768a2-3b33-4a52-a6be-bb5399d2810a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("41cb0525-249c-4814-8424-cb71490ce3c6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("41cde6d9-4e81-4898-97e7-d4b7434fbf52"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("41ddfebb-f8d7-4974-b4b9-a4da258019f9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("41f36ddf-8577-408a-ad4b-ecd953d4e5a1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("41fd8c66-58ef-4409-995e-a1cec3a036b0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("422398f7-b392-47f1-b2fa-f0db4016eb35"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4257d796-e941-418e-a249-7d4a9c640d59"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("427ecd9f-2ad0-49a5-95b3-fb396ad93add"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("43a33f0c-75e1-470b-8fc4-a41ffb060f96"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("43d1b6dc-ddc8-4b80-8108-3af712030d16"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("441777cf-ac2a-4c17-b255-b607e3daf5ea"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4453b68e-f880-4047-9d78-aa16f9f16893"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4456b5f7-1f5b-46de-8d43-f7450836e6c0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("449c595e-e0e4-4132-a192-ddb522f78842"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4511486c-bd20-4d06-8a44-7f2715f2595b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("452d0866-2adc-4607-b8bf-b9b2fa49e468"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("45321e08-0ce1-42dc-9301-774a386a3a02"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("45585402-9845-444d-8027-b1c98355cb3b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("45678767-8c0d-4ac4-9ef9-b3a2ebc93a35"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("45e5426e-7813-420a-923b-ade2d48ddc09"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4603bcb0-6d29-4a43-ba6d-950566df08fc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("467762e0-5e97-475d-a84f-586bde9e2fb5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("46b36854-751b-45b7-97a3-57c2870d954a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("46c33f97-2b74-4527-a391-9f9dbbee2c86"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("470586c1-ec88-43d9-bc48-3b20e41bb02b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4776e426-198f-49c1-854a-8d8df02215fb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("483af7d6-3582-45fe-9150-a41e970bb45d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("48799420-a728-47d7-8f0a-8255691ebb3d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("48b7912b-ab97-4d3c-ae45-0b7657a1a587"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("48f5fc4b-2140-4f79-8fa0-7551061adf34"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("48febc5c-957e-4003-87fc-571f7267525b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("49084652-fab4-4511-9b83-7036b7ff19e5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4934e383-a7c6-440a-b54b-c5b57612d95f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4945ac4a-e12d-4dc6-bc21-268736388e99"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("49ed7258-0ebf-47f9-b268-bedc96b85c74"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4ac046c9-63a2-44bb-b5fb-e5f1c5d00d41"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4ae0a4dd-b73f-47ba-a455-5d5827eb9f3f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4b784e83-b3fc-4ff0-98a0-e72fab999230"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4b7af622-cb3a-48d1-b33e-6387bc7438d8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4b94c6f0-58e8-4ea3-854a-774601bac426"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4b9dcb2a-748f-4b9e-9701-3bc1974792c0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4c0e0519-3b34-4864-a335-003c32b0d4d5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4c441abb-e2a0-4d68-a113-2c30021c298c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4d903639-0629-47e0-9717-505cd6594ec9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4dbc6306-1882-41ba-a423-1faf9bfeea80"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4e2da2b7-c390-4a5d-9d74-944297be0124"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4e4b5c60-d5e1-4290-a1f5-9495d67ba490"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4e71984a-5cae-495c-a08a-9d8bb290b435"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4e77765d-e512-4332-99ed-ba801c0163ba"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4eea7ec5-561a-4426-8705-08a2a8038e02"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4f1780fe-2415-4853-ad1d-b63b1ca85804"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("4f994117-4b01-4e2a-8146-470db1fd85c8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("506d137b-7449-4046-bcc5-75982ee69641"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("51e7a74a-9845-4b22-98a3-88211414cd5a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("521daa13-e5dc-4057-aa05-4890096cd323"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5240dd62-4e46-4e23-a419-b8da65b3a36a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("52f51d65-3094-484d-98e1-ec8650a95739"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("52f800d6-c663-44cf-bb8a-20a7d291fd10"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("539cca9d-92a1-4efe-97a9-eba8d9ed0ca3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("53c96d7f-353b-4b77-89cc-bd96cc8ccf18"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("54083618-39ed-4b6c-a157-18851bd97440"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("54471211-2ff5-4ddc-85f3-0d60bf5c4684"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5476b7f5-eb9c-4534-b628-d7a3509b4cd6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("54b05e32-3635-4161-b401-445f90a6effd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("54f3462d-5fa0-49f2-b8c4-03280e62a671"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("54f94764-04b4-4571-a448-aafa4486b4c8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("55128586-9421-409c-8a54-34df6ff1a40b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5563aa98-2d9f-4dad-8a30-648ac7a32348"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("55e73bdb-1a30-4a4a-8b80-e1acee7bbc41"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("568d9d19-bf02-42bb-b23c-fcfbdc695352"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("568e5360-ac72-4908-84a8-d5e57bcbba33"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("56986fec-1797-41d0-892a-44a5070aaabd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("56feb2c9-c84f-413a-9db6-be4a1368f3dc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("573e2247-9c48-422d-9a7d-6d1d52a0514e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("57a24b3c-bd5d-438a-8333-c08ca8357c14"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("57b3fa0a-98c6-4ccb-8552-365591eab194"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("585d6447-007e-419a-84f5-820c06bbc0b3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("586bba5a-b04c-4026-84b1-fc2fb6bd6da6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("59970d85-1e6c-4ccf-a5f8-71c0606a4066"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("599f514b-46e9-4d27-a61b-cae23d694f17"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("59a72c77-d435-4702-9d0a-8d451e1000ef"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5a26f2f4-0126-429d-aa08-23ca802d83e5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5a9c4912-61d8-46a5-8069-98361e71ec09"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5b399f21-89e4-455c-8852-5eda8b4394fc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5b43d5c2-1ea2-4e24-a0e2-0e583460612c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5b8e6026-9607-4c3d-8a6a-4b9914df045f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5b93d0d0-fadc-4ad4-832c-a0817fcf0aaa"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5bf61381-ddda-4bbc-a4cd-1c678eb28aa0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5c169b82-0445-412c-ae42-73b95055ba90"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5c2c3fa1-c28f-4799-a80a-a12f9ac46043"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5c344156-6088-4698-a7ac-1ccd5cce8fd8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5c7e66b0-e3d0-4ff8-8785-016eca0bc151"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5cb1e64c-317a-48a9-b791-23e65778d5e3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5d14e0bd-59c9-4583-8b62-9ce334d94ccb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5d408b99-fb11-4952-8ffc-3feefde0f856"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5d5e5e67-35b5-46bf-a52d-2108f635ae98"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5dd44887-8f16-4ffd-bd54-92d85672f3ff"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5e2f5e68-c974-4207-938c-2a0956995842"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5e393a1e-c546-4e38-a8c0-6b49efe08670"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5e43eff2-b58d-409e-9850-609bc3b90eb5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5e4f3f10-2dda-4d1b-93a6-abcae4462896"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5ef98250-615d-4fb8-b7e9-3575a4697442"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5f27f985-fab8-4fb1-8a44-39572f02a988"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0049-a98e-447d-82af-ce3a840081e1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5f73322a-cbe1-4b84-a7eb-b36c0121f815"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("5fc67266-9337-464b-8428-cef5c6c78b50"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("602a8c7d-49a4-46cc-9bbe-575468f963ed"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("602df369-8e7c-45e4-9108-4ab48a3b5b52"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("603a24d7-d636-4462-a814-a96d147052c5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6079f483-a339-4ac8-98d7-77562cdb73d9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6096909a-c116-47e6-abd9-5fa9f6a8801a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("61a24679-d838-4beb-86b8-83cb7b164c6e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("61a30da6-c4ef-4659-89eb-d5946a3d1635"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("620416f9-66c0-48b4-97cb-f1d00726002e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6207eda3-f8fb-4373-96db-b2875ade97fc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("623d161b-8f71-45a7-bdf2-3cc404efccbb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6343600f-cdcf-43c4-9fbe-c16268ca5b82"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("63a1f60e-a5dd-4eda-a690-ba2796cb6c6e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("63ba3c02-1ab6-4bee-a164-986a5437faf7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("63fb9398-f7f4-42cd-a7b7-0a15d080755d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("64b5a197-82e6-4bd1-8f21-f0adb58e9020"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("64c98255-e69e-4317-960c-a8f272abc89f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("650b90f0-dba1-4f76-b1c0-77c8b26fab65"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("652d2863-ee40-483e-8b32-308099c404b4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("659639ac-4ea1-478a-b4d2-9f2e69f81f95"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("669f4a8b-8316-4191-9e42-837c16c38129"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("66ccd804-4898-4801-ad2c-e9c203bb5d4b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("66ce74af-7a8e-4d51-9a50-3ad686110099"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("66e895bd-d18b-4cd5-8205-90c2f44ad851"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6703f3d7-6a8d-46b0-8768-01c039bccdde"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("676197a2-c33a-402d-8d40-39e26d780dce"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("67daa06c-5480-402f-a106-4a59424541c0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6810dcba-fa22-4492-8150-45a4231e08c4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6880ba51-dc19-4909-a1a3-e020c7314ce9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("68a50a97-bbd3-4fc0-8309-372e97cfde32"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("68f36c2d-fb58-4d01-9fd0-fae49c6b0dba"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("690d09bb-32c6-47f2-a631-d137c0d62c83"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("69451a8d-7f49-415c-b67f-9fdd294c0dfc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("698dbb54-ef6d-4c50-ab87-bb34182b045a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("69a2f340-3cb9-497c-bf70-ba74219cf478"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("69ad602e-8ce3-48d3-a15b-69e95bca3fca"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6a366599-82a2-4855-92ed-207413acf2f5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6a5ac63d-f272-4c6e-aa20-5699cf9ef691"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6a7a839e-4c6d-4e8d-8207-3a35e9b261e5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6a89ba14-c1b6-4cea-95f7-cbda02a6135c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6a995fcf-65ed-4b50-9b4e-3000a4ca104a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6aa9e5b5-3668-48f3-9d93-6e82d988d876"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6ab37837-d871-420c-b28f-4e0869961873"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6b21fee8-81d3-4ddf-b835-b8391bebfba1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6b3023ac-2152-4bd9-8ae5-3603c4a6f2ff"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6b6265a7-a9f7-46a8-8d57-639861882a98"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6b6fc85e-7e70-40c6-8435-f49de34fda85"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6b7a5c7f-ef28-4b49-9146-811448294ced"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6ba13e6e-bc4c-464f-a500-959367597da7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6be5f255-bf60-4300-93e6-677c0e6f7790"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6c0017a3-8755-4524-b9e5-67b15d7fbda7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6c63381a-62cd-4196-8ab7-8aeeb4449846"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6c938a56-9995-424b-9290-ca15eac02f6a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6d21779a-1a7b-414a-bc28-781a4e179e5b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6d3ec15b-6cbb-4696-8ea9-2f885ebbc7f9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6d7f113f-6249-49c9-a4e5-aeb882a77896"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6dde77b1-432c-4c74-b41d-a1fc63bff512"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6e0215cb-211e-4313-bfa9-fe9871bc9b5b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6e3a3c11-ff1f-4c02-8c45-c78298091cc9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6e88974a-a40a-4761-b2f8-fdc73db2d4d9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6ead35ef-ccb3-4c99-941a-b8348d91aab2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6eb54ef4-365c-444b-81da-f847f22abbb1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6f106fbf-3271-4f0a-88d8-c47e6336abd6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6f58a72f-26fb-43d8-ab67-f9fff5b6ba27"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6fae0a03-435b-47da-960b-a968e87b7f3c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("6fcb1826-a232-4ece-afe9-3c4f34f902a2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7048bdc9-8544-4ae3-a226-f65dd247357a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7064789e-f7cd-46ec-8d7e-49b35a5bac96"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7096e73f-734d-4cc9-81a3-6d69110739cf"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("70af77ce-b1e4-43a8-a41e-937f92c6a2ed"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("71b6bb58-8ec6-4fa4-82ad-5af730fd1857"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("723deaef-8901-493d-80bd-275d51c890b2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("725462d4-bc5b-411d-847b-e729660b7886"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("72a3f830-a37c-47d3-81a9-acb3f24314f2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("72d2031c-d163-45d6-a737-df81411acdc7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("73ccd908-b986-496b-8073-cc61fce37b7b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("74484eb2-dfe0-45cf-83be-559fe64bf46c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("745a3b11-d612-4a35-b8a3-d27074586dec"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("74e5334c-6f20-4d3e-aea4-60bc9d131ecf"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("74f01878-7519-4a8e-b1cf-175d2d7b8258"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7520bcbe-194f-44ce-944e-0c5c1b130ad0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("755ca439-3e02-4cbf-b6d6-f8cc227faa57"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("75a8aa66-04f9-47bd-afdb-156573a77be8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("75e91edd-1afb-4105-a927-395688ff6d08"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("765f849d-c51d-4f43-9242-b2ec5473311f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("76b23feb-0b9b-4d0b-9ae6-b9cde950e59a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("77314759-95f0-42f9-964d-5da2cf4b4eb3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7783ddb9-49d7-458a-9927-96f26a72fe4f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("77ea1cd3-2fe6-4ea0-ac88-b0fce24fa456"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("787257d5-1116-4986-81a1-a75a48b636c1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("78c38344-8a51-4798-8726-2ed403191b98"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("794a5ddd-a2e0-423b-b849-36ab2b589e47"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("79576e86-86d6-4cb4-aa80-a8a6a0bc4fe2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("79583c64-c324-40cb-8470-0125211fb61a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("79b75c45-8adb-4e75-90db-afb15955a806"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("79c64994-a277-4958-a1cb-eb470f71efac"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("79e23a24-2efe-4418-91dd-22425cd223de"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7b0e47f0-64c9-4e88-8401-868e08fb5ad1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7b91132a-f38c-437a-a7c9-bf24cbf0fd01"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7bc0904a-ce0d-4afe-8b23-54c1f55a6181"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7bcce654-f09f-42ba-97fb-c9e8ca9b28a2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7d1883f6-f530-4b8b-85b6-ea9f0c60be49"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7d55f303-c55a-4050-b373-0e17d4a70203"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7d589704-fa04-4b66-8d12-4a6479ea4996"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7d784bb6-555c-4f76-b144-f9fdee72a0ac"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7dbe44ba-8a83-4086-94a4-b5418b970e56"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7e17384b-ad4c-4b5e-b132-37d338cfe4c9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7e42346d-9b61-4b0f-a564-b5e0160bf309"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7e450815-ecaf-411e-8f4d-ada6d08772aa"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7e6f9768-8cf7-4975-bd07-ab5c12d51b8b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7e7b2b30-67ce-442c-9935-614c78bb8010"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7eaa16a1-864d-4cae-a928-9c989344c498"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7ebccc93-7451-436a-8953-e1ec87744a78"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7f01102f-553b-48a7-bb62-46d973db19aa"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7f7a0f2f-11a9-4026-bf16-8e2a648f44a2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("7fc369b1-672a-43a9-833c-44e2f49a5739"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8012fa04-0dd9-4924-8644-abc3ec673986"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("809dbc65-43f1-451f-87ab-488a04ad6e1b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("809dd057-14bc-4a81-b1b9-a5633dbdbf65"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("80bfcf9d-eea9-4efa-800c-e87670d90b74"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("814774c0-3f31-4d67-880c-73d1d3de7f30"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("814d5162-2675-440c-b6c6-77727c983798"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("81f1c6f8-68ac-4de6-ad63-5f094dccbb91"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("82062d17-e47c-42f4-955f-3d8fc5e4eea1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8218543f-09d2-47c5-8d23-bf96f1867331"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("82bc703d-02b8-4a17-ab03-ade48eac965e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("82f90dd8-5cc8-404f-b770-b539b6668249"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("830610fa-6329-495d-b11a-739c0cb276c1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("831fdf24-bc86-4cbc-908a-fd7f339a8cd4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8357cf43-cb12-4d9d-80a5-c1e96120d6df"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("837f946b-9830-4b7b-844d-709ac55056c7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("83985fd4-4dba-49fb-a4f7-cd4ff933a0df"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("83bbcd50-1c70-44a0-b2d0-d05f5b43fd28"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("83c7e14f-9c0b-438a-b284-0ba826d157d9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("83d061b5-5c25-428c-9a1d-abc06e450d55"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8428d7ce-9890-439a-b9ab-870ba46da27a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("844ff842-f795-48dd-958e-b03540a59ab0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("84b55337-5f63-4626-af29-d4482d01ec4a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8577e2b7-516b-4f81-a7f4-1747b0f74088"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("85a949e4-c5e1-4d10-9f97-4a3aa30c6eb9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("85e9dfff-1731-441b-ae99-06d5b68f88cd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8626c398-dbe0-43a1-b3a2-ccae6590181f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("86381b95-de76-41ce-a47c-482eed545151"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("86683f25-5adb-48af-af55-6b4a0ed25e9f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("86a1b4da-4e1b-4958-9cef-77e1394d9825"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("86b72db7-67ec-4390-821c-c9a1f2cf40e4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("86cd0919-7371-45c8-88d0-6cace813cda7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("870f339e-2a08-416b-b408-0c4c90447db6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("87284cdb-a389-48a6-8837-dc728a5358f1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("875bd2d3-e900-4684-a41a-94e082f6ae36"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("887cbb0d-b8e7-4388-baee-ae19e2dc051b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("888a33af-0c3d-49b0-936b-c1ff8fad4160"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("88b2751f-20ba-4af5-bcec-8e66789a931c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("88ba4b8b-4290-49d6-b44b-714059987acc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("88d2a1cf-ca20-48e6-8cac-c64dcc073a32"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("88fd42a8-bdf4-4db6-80e1-10e324cffef3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8908e710-b9af-428f-88c7-eb28c3995c2b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("89771797-a8ae-4fe7-a1ab-0e833c484f62"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("89876df3-a12d-49ae-96b0-0df00bfbf5e7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8988f4dc-07f4-4e70-84f4-95b95796feff"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("89af2bd1-db46-451c-9c76-76125b95ac5f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("89f80233-d9f6-4cf6-b96c-bb48fc7512e6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("89fb04d2-146a-4e6d-8a5b-07d17d350cec"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8a0c07e6-e3f0-4b86-9236-af6e18406dfd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8a2882a3-648f-45f9-aa8d-ececc5ed74ed"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8a305670-ae99-4060-895e-e8e259d2e890"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8a3af5ef-8ec4-4234-b906-76a4fc48af53"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8a642185-2b6e-45b3-8098-51e5e3b0a9bd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8a7a1b18-b926-4581-bfb5-55d58a7dfc8f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8ab32e89-aaf0-4aa7-9fdf-16aa1628b184"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8b09af3f-02e9-4aa5-9f51-9677c750df01"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8b6bb552-dd78-4350-9718-3c0dbbc1f3c0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8b7fe02c-02b4-4047-844c-4dc27e5272a1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8be6e8a5-3514-41fb-a183-2314bb723f5f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8c5163c3-3be6-4a0a-91d3-a5cc9e94960b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8d29fd19-97d9-44b2-8e16-ba53da11c9fd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8d6c756c-46dd-4e3a-bc71-512b4fedc501"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8dabe2d3-6b0d-462c-a074-54f30605d303"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8dcde802-c524-48be-a049-ce57cf83e6c3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8e5ae901-f80e-4ea4-a2c6-84849c655619"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8ea96071-b11e-409f-8a63-ebdab7cafc72"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8ec6d789-734e-4f49-b394-7d1768df4171"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8ecbd553-3c0f-46fe-9e61-7275b90d8b32"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8fa23a72-225d-4d11-90d8-361c50337050"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("8fa606a9-a929-43d6-b35d-bf76b9386bf5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("902d92c0-4b6f-44f4-857d-e46d30292049"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("903a5330-4d14-42ed-8896-86e26210933f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("904b0552-d58a-4731-bd00-014221566ca5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9053957f-d257-4601-86d0-b2e8af9b3d8c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("906187f2-d356-4e8b-a9da-b26be583cc01"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("90b14adf-3c9a-4d19-82b7-1a637e1857fe"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("913ea6f6-f52c-42a5-83b1-6a3cfeb03ded"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("914f15e9-34c5-4442-b8d3-0088bc4ec506"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9166560e-0bbc-4360-977d-77d74e743c26"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9195b20c-427d-4741-ab8a-f670afad3009"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9205d916-75b1-4259-ae01-85554e76f2d4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("92161bf5-a77e-4ada-b52f-da49c0f11fac"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("923c414a-faa8-4005-93da-dfe508059dab"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("92617358-a655-4a9c-8888-0785ac6edbfd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9262c209-1893-4140-a771-9ea7d5a8837e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9313ba2d-7e08-4cea-b007-99d5e25b3d93"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9365e71d-7eb5-4fe5-8f85-41249181f66e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("93685ad2-d175-4991-a458-2a4a83604bc2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9399cfa5-e322-4cb7-8d06-0320d70d8931"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("93c7994a-0513-4189-9b9c-d907dee9ac40"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("93d9c288-8b8b-47ce-9126-a0f7135cfed4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("93fe8e7c-38b4-4c4b-b941-e8d478bab140"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("949592c6-7bd8-48d7-964e-e1f46a6eca8f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("94efb361-b0f5-4088-82fd-bd6ad06f9968"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("95603c7e-3045-4172-8cb0-1778d7086ddb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("95b26ced-a217-413a-8793-8288ad4620af"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("961a5f60-f6f6-4dba-9c6e-c69fe7adaa3a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9621729a-1441-4ee0-99f7-778717395be6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("968216fc-cb37-415a-8dc6-2b84390f7f7b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("96ca8dba-fff7-46b7-806a-0517a9e83483"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("97278db2-7153-41b2-a552-67308dcd1036"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("97422f09-6c84-45d6-be0a-798315802c21"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("97a01721-3147-4c02-a0c9-61e6a42eabbc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("97ec2904-13c3-4ac3-9bfa-84f1e3b410a8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("98045a7f-2f87-4489-94ca-08ca11059442"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("981a272d-00b8-40a5-88b8-88fdbc1d0167"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9833945d-baa8-421f-98c6-990e5fea3105"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("988b966b-902b-48b3-9d77-78549c63867b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9895085f-c8df-46ad-b394-32bbba9df751"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9895bd17-d5fa-49d2-9c4b-e486872571cb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9922e703-5213-4a72-8439-d90899989256"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("993433b6-45a0-4b20-886f-cc302ee6642a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("99aa8e4a-1d19-402c-a06d-defb35ccf1f5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("99cc5028-c62d-4d6c-879d-440e438ebaf4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("99f257c2-9321-4612-a38a-c29070c7145a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9a0e8988-58f3-474f-a54d-1d93cec774d3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9a313f44-5338-4248-b7c3-b8849a05c300"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9a989a79-692a-4b3e-8d46-ed56af281131"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9ad2a827-ff1d-43cf-bede-e4603fcf3e6d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9af27543-fd8c-42dc-9d8e-7250568f8357"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9b6ced47-0889-483f-8f44-b8388d504911"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9b7f0aec-cb23-4f77-be12-20e013dfe5b8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9b82ad6a-908b-46d3-a7d2-04ca9c699f60"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9b8968f3-54cc-4fd7-849a-0464f953de05"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9bab3034-e7b1-4ca3-812f-c9452c0ab32d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9c2b9bea-886f-4716-90e8-d58915b0f0a1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9c4060e8-ff5e-416f-8ebf-959cada59153"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9c6cdde0-9ab8-4d33-8531-3757a8ce781a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9c9a7a1b-8988-4679-be3d-5f12b49fa81e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9cd6aba3-5dd9-43f8-a2d3-d1b3f218a367"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9d1526b0-17d0-44cc-bbbf-80dc3c21c7f3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9d19a549-bfba-42a5-a826-cc1e273aec3c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9d1ca452-c385-4365-be10-d66b9470f72c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9d71b61d-4522-42aa-b066-eca80cf06548"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9da63b09-30b7-446a-987d-bc40054bcb07"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9dd0df2a-f484-4499-a44f-9a44645deacd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9e1ea030-1080-455a-8081-62db7ca11cdc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9f37d7a7-6410-4fa4-abb9-270b7361471a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9f4860bc-fc18-4356-b734-e8875fcd0e2f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("9feea11a-70be-4e03-b470-48f0be1241ef"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a02b1f22-d317-47f1-9d1a-a073620d1ab8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a030d3d5-275f-4c7d-831d-8cac7c025562"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a0525451-95d3-4d81-9674-9d6f3dabd374"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a09eb6f6-dc61-4b2c-9ab8-44b7e7bb0586"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a0f1f4af-20f5-4471-8b7b-193be7defd1c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a1044c8c-6719-42b2-8a70-4b8ae90ef4e1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a119b0c1-f259-45df-9c25-6dcbed9e649a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a14fa821-2b29-4907-98e4-17b20f864339"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a1d04acc-3764-4ce6-8a94-52e5284a4657"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a1ddd176-36e5-4466-b590-dec0ed7ee327"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a236f3bd-6081-4036-94e7-eb757156cd8f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a26fd8bc-81e2-40fa-bb4b-33ffee23813b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a2c0c466-8fae-40ac-a74d-eb07808fc0f8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a2f3b6bf-3b76-4b9d-a9f1-441233bc6cc7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a33a2cfa-a262-4cbc-a2d7-fb16316fd6b8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a348904f-8b3e-4725-884e-71a9c653a9f7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a4266d01-5175-467f-be1b-25b10205df67"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a4355b2e-f872-4523-badf-dd1064931b70"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a475f992-8664-418b-a482-190cb1737be7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a479d3fd-5a0e-4952-84ab-2f9a2bdf23fe"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a4904da7-a1ad-4c4a-9692-3a1b09266daa"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a4986837-a820-4e84-9206-14f2bcce4b4b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a4cd8a35-0ecb-4cc9-a700-bea74bdcc235"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a4f7d07d-66f7-4b8b-a582-5658d82a034e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a51f83d6-6031-4095-813c-a2598b4adcaf"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a6280b76-a27b-4961-98f3-069f0aab0b73"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a64200bf-21ef-4d7b-a4a9-83b02dfc335a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a663dedc-a0ef-46fb-b09c-7d8d3ff53950"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a6793e53-ea1e-4024-aea0-2eebd8072ac1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a6cf734c-2892-4e9b-8a11-310cac331d5d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a71b074d-7b94-433d-8723-7433e7d799af"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a79ce4e7-ebc7-4360-883e-d1542a31f96f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a813f092-06fd-482b-ac90-9cac37ad4a12"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a855f09d-06f4-405a-939e-a2178ef3e141"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a8d6c702-ffb0-49e0-9f1b-60c7292ed9dd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a955abe9-2223-4005-a4fc-4364a6ee5442"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("a9575c57-23f6-45d6-a204-7944d8b7e3be"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("aa109aef-f168-40b0-a30f-295f5d6d697e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("aabed9cd-00e2-404d-8200-421d5d99b20b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("aad6237b-fb4c-4b78-a02e-0d415ff9b1cc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("aae9db66-edab-4fe5-bde9-69ef9653b7b8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ab01fd94-fbda-493b-b32f-dc1e2b31b3ea"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ab320ac4-d5f4-4f31-8f4f-3ac5c8437150"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ab56292e-f6fc-4353-8778-8f08c788c1bb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("abb03eb3-4ea5-44ab-b5ee-f6b66434a976"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("abca27d1-9088-4b9c-b170-39ba71ad04e3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("abfeab3d-e168-4fb3-b08b-5626ffeb8a7b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ac5da383-41c0-4a6f-8df6-ddcaac8fb20e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ac5ec140-81ab-40ea-99f3-de5b982a4522"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ac618b26-a9d1-4314-8208-ec791ab5d57a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ac9a0ce9-848a-401e-b634-4e7864328ab1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("accbe5dc-3d03-4fdd-8ebf-5c0a7a5ac86f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ad18e5ac-7b8d-48ec-826a-69488c0b0b57"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ad29bac3-c184-4c5d-839c-973e38d4476f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ad2dc500-ff4f-4bac-9f63-7d7565f1388f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ad95e387-2a0c-4176-8efd-7fc8ef963aff"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ada723b1-6e0a-4152-8985-c37800816c72"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("add4dc09-4a00-48e5-b679-ef6f53258db3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("addedd2b-539f-4799-84c6-60da86db82f4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ade88ab4-f6c6-4589-b426-febbc713f981"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ae5a5a81-7c56-4487-a4d5-1eff7fd54915"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ae7d8407-f96b-4c8f-95ff-6eefa388dd9d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("aed2e2c4-e0f1-435d-b996-e098089e4b6c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("aef42696-3f95-4bbb-8a42-85388f0b8e5c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("af567a4a-7b91-41cf-b41d-6a3d8338269b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("af617cb1-3196-4943-9608-a3ec61db0ce7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("af8d2036-1ff5-4071-becd-e3b2f3a13a34"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b015d297-3ea1-4ae6-bc13-eb5038d1fbee"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b07dd9ec-9609-4d10-b108-fcbbb76c4cc0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b0e09f08-4300-4739-b022-6d1068c4bb7e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b1079477-4157-48e9-80b1-a1a19a2d3bc4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b1377f75-41bf-4dbb-bbf0-a75a98b2acef"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b13f9bee-7419-4631-a5d8-4c8a54364047"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b1913efa-b063-4fb7-a3b7-2dfa62437ad0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b1e4e419-5325-45c5-a965-f5fa299004ce"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b21c20c3-7219-43a4-8aa3-bb2f9e1e39c5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b2afa0ae-3ee8-4571-a062-421b9a345371"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b2eb09be-d02d-433c-ab26-3414a0f074d9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b3651821-878d-48d6-ab5b-6cf25c1bb1ff"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b4980246-f6ca-4d16-8aa9-fa6a9fef029f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b5620843-01ad-4935-be2f-596d40b9c8fb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b5834387-bff7-449a-8eb8-f9ec4544abb5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b5bc9055-998c-435a-b848-d1f6a8abcc3b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b6243ee9-618f-4ff1-998d-6f9e7627bd8c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b6ce0ad3-d71e-4fef-9a64-ac3579a76b36"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b6ea2611-f9dd-4997-b1de-012d5486869b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b735a01f-b593-4b9d-a668-eeb82e287a31"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b7a7ac99-18fc-4239-bc73-eece293ac47b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b7b10b46-0b1d-4396-b5c9-9f29bb6e435b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b7c4a18c-b9fb-44be-8213-29661940720f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b81a0443-3f97-45da-8a69-af43090b457e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b8403c50-12da-44f6-aca3-67110ca0c1cf"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b8ddb7d1-d788-45d9-8554-f862bbcf52af"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b909c919-98c0-4f25-8ee7-f538b695cb2c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b917cb13-620e-42ee-ada7-6d7f371c7a63"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b92e538f-fe19-421c-af3a-ab9a07b14271"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b9a88b04-488a-4794-9d62-94f6c4b7210f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b9bcbcc2-1f53-4c97-92c6-7916ab5803bd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b9db51bd-3230-4af3-b682-f60e60f10f6f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("b9fb223a-4e3d-418c-b6ae-dd3e4a1a8e4b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("babc4b84-e6d9-4938-b5fc-8513f6fae194"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("bb34f3b5-e4e5-4dd7-8e22-23095141e683"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("bb439f7e-db3c-442b-97b9-f5bb641af905"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("bbe7fbe2-0922-4430-9687-7535ddbc472d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("bbea7421-af61-4fd3-bd63-990ba26516c7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("bbef105d-aa6e-40e5-a508-cb78d9c1d5b5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("bce84a4e-0ae7-4b22-931a-5b7bb8081be7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("bd4cc1f1-961e-41b3-8e54-486af7db3229"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("bdd74d9a-f6d3-4b2d-9d6d-06bb88339ec0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("be53fd0a-4291-47ae-a4c7-7fb3b3040b1d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("be5a289e-7290-4243-a984-8082700ecca3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("bee47e17-7bbd-41ac-91ce-f5e34d452628"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("bef03eeb-aa24-400e-9e8b-b6ae0a82a4c0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("beffdaf5-a1f2-4fc2-8d6d-593bea8a3c7c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("bf65ea74-ac18-42e7-a6c7-69a924905765"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("bf9ce839-db0f-4d32-b807-488869c0f4f4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("bfd4df73-403e-4d33-adbd-6e1fd74716e0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("bfd9573b-ab90-4e69-9edf-febcad8cbaeb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("bfeecd10-a44e-4271-82e0-859ea60b54e2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c00bcc2b-b938-44a5-9c01-6d4498e3e117"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c0639c2e-abc6-412d-b406-3c90e54585f7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c0e11583-84f6-4b15-bd0c-b1bb192a0751"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c11a7aee-5178-4282-b387-16acc8361225"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c128202e-9e24-4f4f-b9cb-3bad0540b9c8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c1888488-590b-45ca-8bc6-f8c699961c08"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c190548f-4cdf-42d9-a2d3-bc0ba7ee5c40"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c1f4fa52-e804-4ebe-afb7-1f5f7d3c3155"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c21c43e9-bd88-403f-ac45-d7acdce1a875"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c2459bf9-482e-43ab-829c-7a8b43f2c7bd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c3582ed9-4b93-442f-be76-e3f662fd0aaa"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c3bb2acc-3b55-444e-b8d5-14ee393011cd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c3d6af81-f54f-4dd3-9fb6-35e05df6dd9b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c42404f4-4a3f-4135-bc0b-b1b80f614f5b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c4454747-1414-43ff-a5a8-9820a6026ce3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c464ca0b-786c-49a5-89f0-3e706eeab334"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c46ee182-222c-402d-8640-422f0b598b1b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c48bcfd2-70af-45c3-a903-ba27214a6a7b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c4b5f391-a2cf-4cf7-aa59-7aa8d8e813f5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c5493ec3-bf9a-498e-8d66-bebe512a7bd7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c5751f30-8446-4fc5-b64e-0add4155f608"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c59bf423-0e44-4efa-8e87-9e5abfd01ce2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c5be1e88-557a-4242-b39e-7e458762ec43"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c5d448b7-a2b7-4cf0-b3bd-5651e4281e3a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c6049188-9e77-4b78-8902-70ab95e6d43a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c612c09f-d58a-436e-8b85-d9e3a6cd58e8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c6448e42-f2b1-46f7-ba66-d75bf70bf9e7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c691b401-f6d2-4859-82a8-f30b814328f0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c6dc9c1b-f80c-4357-9979-168c8bdba5a6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c73448dc-a606-4b2b-9956-2cbb19099611"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c759983c-892a-4bd6-8db5-a85527dd32f4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c7e173ed-db61-4bc1-9858-f0a6d9385882"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c7fe6951-d49c-4d05-bb37-f158a51cd820"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c814a18b-2879-41b9-8232-10cb86ef5731"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c81f323d-ca2f-4ee7-8661-8b1d9db94d04"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c81f3c5e-2e31-4af8-abef-195e07796b90"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c851ae44-54b0-46a1-8ac4-9bbffa727617"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c86815a8-e5bc-4c37-9f82-08de129df19e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c88e6809-13a6-4a3b-a863-5bcf65a74092"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c8af3668-ab7a-4b8e-95b9-063faab35ffd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c8b0ee91-2ca1-4a72-b4b0-b741d42d910d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c8d5160d-05f5-4c48-a14e-5a86a8e17377"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c94ab4e1-c6c2-4c0d-9e65-829d4c2d6e1f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c96733be-f258-4a26-83db-f632d161af10"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c96bf380-6f6f-4d66-b2ca-3f079a3b0005"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c97e58c6-9658-411a-a7be-f7e3671b064e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("c9cf6d0e-de9e-40c3-b3a1-dcc196af8aa9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ca3b86a9-d7d7-4972-9f72-7784090e9f47"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ca48de01-4232-40d5-b009-d4fcb1fd7f86"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ca6c2810-9f59-4748-87db-661377ff1181"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cacf676d-9885-4a1b-8d14-d274dc061769"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cae2602f-8424-4065-af7d-90fdf77f2b3a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("caf11e41-b673-4619-99fa-94c6a52545f8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cbb4c3b3-7862-434b-8dde-81459c7789ac"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cc0a6c41-2cce-498c-bc3d-7d755c382ba8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cc58e556-0635-4dcd-a0fb-0249ac010922"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cc58f68d-a8a9-4813-89e7-be656c2dafe5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cc80009e-97cd-4249-81e6-706fc5fc6400"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cca11b45-6a6c-46e1-850a-b68dd9bac451"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ccbd05bc-caa2-452f-a9c2-5323f04371da"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ccf30e69-18de-4955-8b60-cb142d7ae643"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cd065059-d8eb-4ced-ab3d-f79673672665"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cdb86843-7b2c-4c51-91b5-cd5f1063ff44"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cdc45069-7bc4-4668-9b18-0e94487a91f1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cdc4a4df-68bb-4c60-9322-420b845948dd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ce65cc3a-da64-414b-858d-9f9da337a2c6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ce72bd5c-5ebd-4572-854d-71154b9bb4cb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ceab774f-3f7b-4915-8a82-d58759954a59"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cecb1b58-aa8f-421f-916e-3f22d45b9f3d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cefa841f-dd44-495a-a53e-e5f46856d146"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cf352cad-b490-42ab-bd76-324d65648e1e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cf37143a-e4bf-4e2a-b11f-ca92774e1705"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cf891373-3ab4-475b-ae74-0fce4f10902a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cfac39a9-7fea-4a20-9528-af61f8d9423c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cfd1840d-24e5-45c4-8a71-4ff0b57aaed7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("cfe4b97b-9b6b-4081-9efb-ce639ec5e052"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d0022d7e-29d5-4326-bbaf-f494e578c830"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d0130f89-72d5-4a4b-9721-1050f9f303a0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d0320ff5-4847-4a98-bb77-f78a63f5a092"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d0713001-844b-4a1b-b37e-fdbfeb15d7c6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d085e945-8d09-40e8-a0cd-f84e6eee7697"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d0e0f5dc-a660-42f5-b90c-652e7b997f6f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d0e99765-dd25-4076-b6a9-8ffd86f45cdb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d152f9ca-aab2-481f-aaf6-cc94d3ff69ec"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d161e22c-18ad-49dc-9d44-3290ba801b2e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d1e35a0d-fa19-471c-97c4-3466e7e7b7f1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d1ebaa5d-9920-4904-b530-a7b7c0268e04"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d25067a6-899a-4120-80fb-b6bb62c2bbc4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d2ab3b43-b480-4962-927e-dbf808fc7d64"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d2caabe3-3a06-43eb-af55-e561aef0cd7d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d3356aa1-8b12-46d6-b66b-ae9094dcd5c5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d37dbe92-d02b-4e53-a111-6a3f631b3d7d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d3dfe31b-89a7-404f-a368-dd6e065a95c0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d3ff5d98-52d6-42d0-916c-42928b762760"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d4c98c5c-5d9d-4d65-b1bd-71e9100d173e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d4e0dfc3-1fa8-4ad5-865c-4c6c2874f33a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d53bc884-71b7-41fa-a49a-5eb68765ef86"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d53de047-c510-4dfc-aa18-3c864af3bf98"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d54cd6ea-6406-4748-8b5e-623e1d4047cc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d5e9acfb-b921-490a-a941-f4ed4a4bca0d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d5f3faaf-329b-4748-9c14-5fc344493d22"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d63ae33a-a549-435b-908f-47cab9dc8c3b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d6950dce-537f-4efc-ab1f-0b047113bdfc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d697dc66-9524-44da-957a-83f7e9c8a328"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d74d1ff2-bd90-493b-bef4-7c9353b1a48c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d7731a0c-3658-4aeb-9c1b-e316a00c56f7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d7e91d59-de90-4d83-b21b-48e4cc09a1e1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d87de3cb-9aeb-4499-970a-e6c43a7f94eb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d8d605ae-4223-41cb-ad72-37fda9ff1e73"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d9be0ce9-6894-450f-a530-c28b95c3adb2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("d9ef49be-1889-4b41-8ee5-abc892723263"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("da1b2876-8234-4235-b3e6-b4f9518981a0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("dac87581-c85e-47c8-94eb-9e2f1e50cbe6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("dafd9f40-11d7-45ba-a8c8-8d0b0bba8999"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("db4e0f1e-aaee-46c0-b7f3-0cfa41cfacac"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("db5e6085-5cfb-487b-923d-2cacd4b672c0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("dba54bfe-5a57-41f8-9ef6-7025b131502c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("dbacded7-d4ee-4352-a057-edfe21340a11"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("dbbf72e7-ae28-4cbc-831e-9e31bfbde36a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("dbc5414d-fd92-4bb0-95f7-2bff9dc22a46"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("dbe6db13-8dfe-435d-9495-94675b8bc636"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("dbfbc50a-0537-4853-a684-60ee4c2a6211"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("dd2c5590-d51d-4ee2-b486-c7b5d5f18299"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("dd38a982-a39a-4f64-a419-d4fe93406475"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("dd423f35-e8a1-41ce-82f4-df62f432c4cc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ddc4132a-95a3-4fba-8321-abc3e19c1d8a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("de5938ff-b562-4cb0-9afe-071ee689990d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("de85105e-5157-462d-95db-962f7f2fea56"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("de966a52-4d8d-48a0-ac6e-e66790c939e6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("dea3e11c-702e-40ee-86a0-742fa6cd757f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("df44200f-6f98-4e2e-aedd-92dbc047cfbf"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("df44a4dd-9cf4-4910-bcbe-f6df92615dfd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("df4dd0a3-7d5b-4338-9230-a796362fa3c9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("df68cb71-c5e5-4449-ae2e-a61d39bc5339"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("dfc491cb-76d7-4d17-aeb2-33584076b019"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e0085a28-6264-4efd-bab3-0224bb1cba4a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e013d6f0-2abd-4014-864d-b7a8d2f96b27"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e01e157a-fb8d-46e4-accc-4c713c43cb2f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e027baee-beb9-47ae-9a98-4b8f97c81d5e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e02ddd9d-c93a-4bd3-9d53-41fec962720a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e0543b31-c20b-4902-aa40-8d0c67a19ce3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e0fcac3f-9400-43d4-a88d-0d30ef2b4a81"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e1550ec3-86fb-4552-ad1b-40d984aa6c5e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e17a0f3d-531f-4663-b0f0-5ce662127531"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e20291d3-d6d6-489c-8490-4ab74a64fe9f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e2094a3c-2ffd-4a75-bf2b-a0d3ffc109d9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e2513a9f-efbc-4bb5-87fe-32b65b74c9bf"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e2aa5f55-3511-4417-bdff-5d8cb1dfbff6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e2e4916c-4dd0-4893-9f9d-8f0c987a65d7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e3163ea5-5abe-4ef5-84b1-52daf52d15a5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e34ff98d-4e40-47b4-b321-4445b0759a14"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e3547776-b9a2-4f32-80f9-e555c8fe0d33"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e3e6492c-5d7f-4cb9-bbd6-880c48a22a50"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e406e4cd-fcff-4db7-ac0a-10714209f10e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e4630765-d165-44de-b68a-18a90a332a7e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e4814233-36cc-4b2c-8a66-4eb948c67798"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e4f9c81c-0127-4dd1-a36e-92c1077b61aa"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e523ec00-f861-441c-80d1-d15030436354"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e5677328-b79a-44d9-bceb-7b1c61fe46ff"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e569705d-4bac-4361-9943-471c0e70d856"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e5a49165-8357-4c6f-869f-fb30b2f806cc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e5d754f3-e083-4504-887d-da68f0f3e7f0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e620c0e3-1310-48d6-b356-8bcdbe9426ab"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e624e813-8a89-4a71-81d8-da11ad4d1223"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e6305b7c-7515-4b7a-8680-c49305b1b0f3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e6769d57-1d00-4ad5-9902-754b507d043d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e737526b-e0a9-4ef9-8098-19afb7626012"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e7b88047-6095-4183-8dce-bea96a83531d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e7d65d6d-c756-4e2c-b34c-4b5d0ac2e6df"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e83096ec-b225-4f34-a65f-1ff1a09c1936"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e85c68ec-ce4a-4da9-a8ab-05ac3852fa57"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e89bb1ce-f01a-46ef-bc08-cdffe5c7304e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e8ec665d-a5ab-459f-899b-0a510ad08ebb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e8f27ee4-f488-4aa3-9ca8-e40e1006d042"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e92f39c8-e1c0-498f-906a-ce205288aa21"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e93b3a03-7d69-44a6-8e6e-56c29e4385ef"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e9a0362f-457b-4d82-b39a-1dd311e9d789"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e9b06d76-79c7-4681-afb9-db1610d55149"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("e9f8f68c-d38f-442a-a415-1c05295ba6c8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ea8054b3-21f3-4761-8bc2-4ec66661a39e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ea87b623-72c7-4ebe-8799-b174f0abfac3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("eae7e990-e5d7-47fc-abd3-eb19386c05c0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("eaeadc27-d5df-4033-8809-161e12ee2cbc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("eb4b4707-14a6-40c6-a66a-97973b1c27a4"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("eb6d601e-f9f3-49fc-84ff-c6d5da1a55f2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("eb8f92d7-4053-4a0f-b526-2cbbf356b6f3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("eba02f1c-044b-4e96-b9c6-d1336250264f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ebe9ed89-d3af-4adf-80a1-270f7c2ed7c5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ec42a235-e76c-4cf8-84ee-6d5f8aa8f7b1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("eccf1e95-8b0d-46a5-8550-a83478de0cb3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ed46505f-fd6e-406a-8cef-03867b336cbc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("edadb9d7-7cd5-4728-84c3-ed13b18f6413"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("edf405cc-9dd2-4b29-a9e9-f7c47a7e3cfb"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ee02a773-4532-482e-a1a1-6a17fc68fe4b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ee4e72e1-bb55-4fef-bf8f-cb5f220c85ec"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("eecdab87-cce4-448c-9f1d-7406ae4c6c96"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("eee1cd98-253e-4cc0-bb7f-abd0759eaaa9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("eee8da13-dc9b-4a49-bf57-836e589f810d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ef843dca-92f7-400f-a036-385b61a2c5f0"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("efb34836-35f7-4127-8e00-7acdd9244e91"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("efbf03df-f90b-4cd5-aa11-695fff827dac"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("effd06f9-7bc4-4eb4-b133-717aa2ad410d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f0cbea2f-17da-4645-afb7-0dcf48c10959"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f164853b-1431-4d68-a0fa-a34af730cbe5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f1a7230b-2acc-4bf0-99ed-b3556c1e0353"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f1bd9f45-1a7a-41b1-8d79-3f8ade4eded3"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f264b40a-caa2-4d7d-928c-06b5b24c5575"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f2b511b8-06ed-4f15-b7e6-6ebe676b2788"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f2f0afe3-2e8a-417e-9a4d-70eb8d9baf73"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f2f4a526-ad68-4822-9cc8-3aa2019af702"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f2fd129d-1917-41d1-b448-7198cb671586"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f302607b-4736-42ac-842f-0ac48a3a91dd"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f3336c3a-2a2a-4b2f-97cf-d498f807400d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f333cb7b-e3bd-4b56-8424-14217169875c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f3e5332a-4465-4f5c-933d-208c355579f8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f40241a4-ba33-488d-8955-7f5ba278a50b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f46afbce-a8b8-4064-a159-c3e56dccaba5"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f4ab5bd9-4ded-4c67-aae3-17b728ab96e7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f4b63a13-bd13-4a86-8d4e-18a9617c3bbc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f5340c14-50c9-4912-b905-a0cbfb3b6147"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f5366014-1dd0-428f-bff2-ea02959059c1"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f6060f3c-f0d4-4cb3-8caf-bb8d5477ecf2"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f61c779b-5324-4952-8784-3dfc4de22171"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f61e51ab-ec49-4e27-bb11-ad942d326743"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f634cee7-3bbd-4ac7-b88e-d785d6466689"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f67f370e-ee2d-45d3-8ae6-66ffb74feffc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f68cedd2-d336-4519-a9aa-5ab6746681dc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f6acf171-9df0-4dbe-87da-72a278c39599"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f70a5b52-9d02-4339-b0a2-428ff9d43d7b"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f71c5650-2ea7-480a-b11a-bbc67898bbdc"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f7688d1b-c14f-4870-b70d-85ff1890af3c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f7985ef1-8f75-4676-9c7c-c450f40d6b8e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f7a20169-f74f-4e63-a9b1-2d232477a285"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f7be29dc-d209-4f35-b72d-cfc252b7751f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f7cbc282-6bf6-4f58-9870-4c1f71ae5375"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f7d0c1cf-1e93-4c4f-ad5c-f5ee08b050c7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f7d4e11e-44d2-4ab9-9b54-babbe93f8c80"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f7eff086-dec8-40e1-9b55-472c06a4c75a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f80c5372-3e84-4b94-8f4a-36287889c99f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f86cfac9-eba1-4b80-b6f1-0647274b8a7f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f9531cd7-31fe-479b-a7b2-454bff71bab8"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("f9dfa0ca-b73c-4165-8592-4e9b1422069a"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("fa359387-3a21-41e0-9f3a-93a331937de9"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("fa806119-30b4-400d-b073-085d277a4588"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("fada7ba2-b24c-425e-b4d2-ae106282909d"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("fae60ab3-29f3-41d4-8fe0-0533edccf699"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("fb13b0ed-f144-4ce5-a7d6-89a9935a160f"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("fb3c62ae-60e9-4ed9-bf59-7d3c0897bc03"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("fbc55d20-e576-42de-81cc-385431d44bbe"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("fbe6b7ea-d5dd-4d8c-ae47-54cb8354ee9c"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("fcb58345-3d95-4141-9d99-fca6529e2f0e"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("fcdb094f-be05-43e8-b157-24348a76dcff"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("fd7971eb-6c9f-47d7-85ff-70a24c3f3508"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("fd867a26-838b-4624-9b1d-5dc092648d50"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("fe93d883-875b-4473-a356-63143cc8c813"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ff01297c-1707-4095-8ba5-fea60c94c9f6"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ff256dd5-c844-4a91-9eca-eeb21f2481e7"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ffc3577d-19a5-48e5-ba4c-a0b4954e9d32"));

            migrationBuilder.DeleteData(
                table: "FlashCard",
                keyColumn: "Id",
                keyValue: new Guid("ffe89394-632f-4916-886c-7b878a50ed5e"));

            migrationBuilder.InsertData(
                table: "FlashCard",
                columns: new[] { "Id", "Description", "Name", "type" },
                values: new object[,]
                {
                    { new Guid("a8e5d29a-6d67-4c76-8cc7-c444f3e6f5b8"), "a card", "card 1", "Text" },
                    { new Guid("e363572b-b54b-433d-a001-2e1252c81852"), "a card", "card 2", "Text" }
                });
        }
    }
}
