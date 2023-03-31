import Head from 'next/head';
// import { Inter } from '@next/font/google';
import { Seo } from '@/components/seo';
import PublicLayout from '@/layouts/PublicLayout';

// const inter = Inter({ subsets: ['latin'] });

export default function Home() {
  return (
    <>
      <Seo title="App" />
      {/* <main>
        <div className="text-center">Create Next </div>
      </main> */}
      <PublicLayout>
        <div></div>
      </PublicLayout>
    </>
  );
}
