PGDMP                          w            PointOfInterest    9.6.8    10.4     Q           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            R           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            S           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false            T           1262    148630    PointOfInterest    DATABASE     �   CREATE DATABASE "PointOfInterest" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_United States.1252' LC_CTYPE = 'English_United States.1252';
 !   DROP DATABASE "PointOfInterest";
             postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
             postgres    false            U           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                  postgres    false    3                        3079    12387    plpgsql 	   EXTENSION     ?   CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;
    DROP EXTENSION plpgsql;
                  false            V           0    0    EXTENSION plpgsql    COMMENT     @   COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';
                       false    1            �            1259    148636    Rumah    TABLE       CREATE TABLE public."Rumah" (
    "Id" uuid NOT NULL,
    "Nama" text NOT NULL,
    "Type" text NOT NULL,
    "Alamat" text NOT NULL,
    "Latitude" text,
    "Longitude" text,
    "Create" timestamp without time zone NOT NULL,
    "Update" timestamp without time zone NOT NULL
);
    DROP TABLE public."Rumah";
       public         postgres    false    3            �            1259    148631    __EFMigrationsHistory    TABLE     �   CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);
 +   DROP TABLE public."__EFMigrationsHistory";
       public         postgres    false    3            N          0    148636    Rumah 
   TABLE DATA               n   COPY public."Rumah" ("Id", "Nama", "Type", "Alamat", "Latitude", "Longitude", "Create", "Update") FROM stdin;
    public       postgres    false    186   �       M          0    148631    __EFMigrationsHistory 
   TABLE DATA               R   COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
    public       postgres    false    185           �           2606    148643    Rumah PK_Rumah 
   CONSTRAINT     R   ALTER TABLE ONLY public."Rumah"
    ADD CONSTRAINT "PK_Rumah" PRIMARY KEY ("Id");
 <   ALTER TABLE ONLY public."Rumah" DROP CONSTRAINT "PK_Rumah";
       public         postgres    false    186            �           2606    148635 .   __EFMigrationsHistory PK___EFMigrationsHistory 
   CONSTRAINT     {   ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");
 \   ALTER TABLE ONLY public."__EFMigrationsHistory" DROP CONSTRAINT "PK___EFMigrationsHistory";
       public         postgres    false    185            N   (  x�mѻJAи�+���zu=&S� ����3���������*�šJm�|�(��ET�4�V����O�n�O��IbM�͗������c^^��e�Oۼ����ղoY �n�ż[������]�r� ��4!X�H�ո��J"�(��0C��=�5�N5�5,�� �w6���֩x�(2�N���Z3����>MR�"D��(���bJ��{�^j���/1�0���-�H%*�(C��a0T��,�ڟ�������MI��訡� ���0gX?w��cw���m6�/V�{      M   0   x�320�40bcKS������N#=C=ݢ�\]cC#�=... �	�     