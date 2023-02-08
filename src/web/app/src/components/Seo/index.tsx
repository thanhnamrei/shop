import Head from 'next/head';

type SeoProps = {
  title: string;
};

export const Seo = ({ title }: SeoProps) => {
  return (
    <Head>
      <title>{title}</title>
      <meta
        name="viewport"
        content="width=device-width, initial-scale=1"
      />
      <link rel="icon" href="/favicon.ico" />
    </Head>
  );
};
