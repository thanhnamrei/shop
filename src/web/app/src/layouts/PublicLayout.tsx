import { Column } from '@/components/box/Column';
import { Container } from '@/components/box/Container';
import { Row } from '@/components/box/Row';
import Button from '@/components/button/Button';
import { Footer } from '@/components/footer';
import SearchBar from '@/components/form/input/SearchBar';
import { Label } from '@/components/label';
import { Text } from '@/components/text';

type PublicLayoutProps = {
  children: React.ReactNode;
};

const View = ({ children }: PublicLayoutProps) => {
  return (
    <Container>
      <header className="p-5">
        <Row gap={6} className="bg-slate-300 justify-end">
          <span>Trợ giúp</span>
          <span>Hệ thống cửa hàng</span>
          <span>English</span>|<span>Tiếng Việt</span>
        </Row>
        <Row>
          <Text>Logo</Text>
          <SearchBar />
          <Button>Favorite</Button>
          <Button>Avatar</Button>
          <Button>Cart</Button>
        </Row>
      </header>
      <main>{children}</main>
      <Footer></Footer>
    </Container>
  );
};
export default View;
