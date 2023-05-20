import Avatar from '@/components/avatar';
import { Box } from '@/components/box';
import { Container } from '@/components/box/Container';
import { Row } from '@/components/box/Row';
import Button from '@/components/button/Button';
import { Footer } from '@/components/footer';
import SearchBar from '@/components/form/input/SearchBar';
import { Header } from '@/components/header';
import { Label } from '@/components/label';
import Link from '@/components/link/link';
import { Text } from '@/components/text';
import { FaShoppingCart } from 'react-icons/fa';

type PublicLayoutProps = {
  children: React.ReactNode;
};

const View = ({ children }: PublicLayoutProps) => {
  return (
    <Box>
      <Header>
        <Box className=" bg-gray-400">
          <Container>
            <Row gap={2} mainAxisAlignment="end">
              <Text italic>Trợ giúp</Text>
              <Text>Hệ thống cửa hàng</Text>
              <Text>English</Text>|<Text>Tiếng Việt</Text>
            </Row>
          </Container>
        </Box>
        <Box className="py-5 shadow-sm">
          <Container>
            <Row mainAxisAlignment="between">
              <Row gap={4}>
                <Avatar name="LV" />
                <SearchBar />
                <Link linkTo="">Favorite</Link>
                <Link linkTo="">Avatar</Link>
                <Link linkTo="">Cart</Link>
              </Row>
              <Row>
                <Link linkTo="">
                  <FaShoppingCart />
                </Link>
              </Row>
            </Row>
          </Container>
        </Box>
      </Header>
      <main>{children}</main>
      <Footer></Footer>
    </Box>
  );
};
export default View;
